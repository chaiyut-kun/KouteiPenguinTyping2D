using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager word_mnger;

    void Update()
    {
        foreach(char letter in Input.inputString)
        {
            word_mnger.TypeLetter(letter);
        }
    }
}
