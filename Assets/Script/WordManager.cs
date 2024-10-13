using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class WordManager : MonoBehaviour
{
    
    public List<Word> words;
    private bool has_active_word;
    private Word active_word;
    public WordSpawner word_spawner;
    public TextMeshProUGUI point;
    public TextMeshProUGUI penguin_health;
    public int score = 0;
    private int health = 0;
    public Animator animator;
    public TextMeshProUGUI nextlvl;
    private bool nextlvl_status;
    private int deadzone = -30;
    // Start is called before the first frame update
    void Start()
    {
        if (Score.GetScore() > 0 )
        {
            score = Score.GetScore();    
        }
        point.text = score.ToString();

        health = PlayerHeart.GetHealth();
        penguin_health.text = health.ToString();
        CheckScene();
        
    }

    public void Addword()
    {
        
        Word word = new Word(WordGenerator.RandomWord() , word_spawner.SpawnWord());
        words.Add(word);
        
    }

    public void TypeLetter(char letter)
    {

        if (has_active_word) 
        {
            if(active_word.NextLetter() == letter)
            {
                active_word.TypeLetter();
                animator.SetBool("Typing",true);
            }
            else 
            {
                WrongType();
            }
        }
        else 
        {
            foreach(Word word in words)
            {
                if(word.word[0] == letter)
                {
                    active_word = word;
                    has_active_word = true;
                    word.TypeLetter();
                    animator.SetBool("Typing",true);
                    break;
                }
            }
        }
        if (has_active_word && active_word.WordTyped()) 
        {
            animator.SetTrigger("Typed");
            
            score += 10;
            point.text = score.ToString();
            
            has_active_word = false;
			words.Remove(active_word);
            
            if(score % 100 == 0)
            {
                if (health < 50)
                {
                    health+=1;
                    PlayerHeart.SetHealth(health);
                    penguin_health.text = health.ToString();
                }
            }
            animator.SetBool("Typing",false);
            IsNextLevel();
            
        }

    }

    private void IsNextLevel()
    {
        
        if (score % 10 == 0 )
        {
            
            
            Score.SetScore(score);
            animator.SetBool("NextLvl",true);
            
            NextScene();
            ClickNext();
        }
        
    }

    private void NextScene() 
    {
        NextLevel.LoadLevel();
    }
    
    private IEnumerator SceneBlink()
    {
        while (true){
            nextlvl.enabled = !nextlvl.enabled;
            yield return new WaitForSeconds(0.5f);

        }
    }

    public void ClickNext()
    {
        NextScene();
    }

    public void CheckScene()
    {
        if (SceneManager.GetActiveScene().name == "NextScene")
        {
            StartCoroutine(SceneBlink());
            animator.SetBool("NextLvl",true);
        }
        else if (SceneManager.GetActiveScene().name == "DeathScene")
        {
            StartCoroutine(SceneBlink());

            point.text = score.ToString();
            Score.Reset();

            penguin_health.text = health.ToString();
            PlayerHeart.Reset();
            animator.SetBool("IsAlive",false);
        }
            
    }

    private void WrongType()
    {
        health -=1;
        PlayerHeart.SetHealth(health);
        animator.SetTrigger("WrongType");
        penguin_health.text = health.ToString();
        IsAlive();
        
    }

    public void IsAlive()
    {
        if(!PlayerHeart.IsAlive())
        {

            animator.SetBool("IsAlive",false);
            SceneManager.LoadScene("DeathScene");
        }
    }

    private void DeadZone()
    {
        for (int i = words.Count - 1; i >= 0; i--)
        {
            if (words[i].display.transform.position.y < deadzone)
            {
                health -= 5;
                PlayerHeart.SetHealth(health);
                animator.SetTrigger("WrongType");
                penguin_health.text = health.ToString();

                words[i].OutOfZone();
                words.RemoveAt(i);  // ลบ word ออก
                IsAlive();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        DeadZone();
    }
}
