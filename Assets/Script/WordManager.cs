using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    
    public List<Word> words;
    private bool has_active_word;
    private Word active_word;
    public WordSpawner word_spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Addword()
    {
        
        Word word = new Word(WordGenerator.RandomWord() , word_spawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
        
    }

    public void TypeLetter(char letter)
    {

        if (has_active_word) 
        {
            if(active_word.NextLetter() == letter)
            {
                active_word.TypeLetter();
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
                    break;
                }
            }
        }
        if (has_active_word && active_word.WordTyped()) 
        {
            has_active_word = false;
			words.Remove(active_word);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
