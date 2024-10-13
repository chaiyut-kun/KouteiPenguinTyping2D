using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

[System.Serializable]
public class Word 
{
    public string word;
    private int type_idx;
    public WordDisplay display;
    public Word(string _word , WordDisplay _display) 
    {
        word = _word;
        display = _display;
        display.Setword(word);
    }

    public char NextLetter()
    {
        return word[type_idx];
    }

    public void TypeLetter() 
    {
        type_idx++;
        display.RemoveLetter();
    }
    
    public bool WordTyped()
    {
        bool word_typed = (type_idx >= word.Length);
        if (word_typed)
        {
            display.RemoveWord();
            // Detroy Word
        }
        return word_typed;
    }

    public void OutOfZone()
    {
        display.RemoveWord();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
