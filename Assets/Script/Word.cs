using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word 
{
    public string word;
    private int type_idx;

    public Word(string _word) 
    {
        word = _word;
    }

    public char NextLetter()
    {
        return word[type_idx];
    }

    public void TypeLetter() 
    {
        type_idx++;
    }
    
    public bool WordTyped()
    {
        bool word_typed = (type_idx >= word.Length);
        if (word_typed)
        {
            // Detroy Word
        }
        return word_typed;
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
