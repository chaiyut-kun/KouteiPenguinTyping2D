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
    public int score = 0;
    public Animator animator;
    public TextMeshProUGUI nextlvl;
    private bool nextlvl_status;
    // Start is called before the first frame update
    void Start()
    {
        if (Score.GetScore() > 0 )
        {
            score = Score.GetScore();    
        }
        point.text = score.ToString();
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
            animator.SetBool("Typing",false);
            IsNextLevel();
            
        }

    }

    private void IsNextLevel()
    {
        
        if (score % 120 == 0 )
        {
            Score.SetScore(score);
            animator.SetBool("NextLvl",true);
            
            // nextlvl_status = true;
            NextScene();
            ClickNext();
        }
        // else 
        // {
        //     nextlvl_status = false;
        // }
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
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
