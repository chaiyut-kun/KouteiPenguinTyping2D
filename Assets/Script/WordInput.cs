using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WordInput : MonoBehaviour
{
    public WordManager word_mnger;

    void Update()
    {

        foreach(char letter in Input.inputString)
        {
            word_mnger.TypeLetter(letter);
            if (SceneManager.GetActiveScene().name == "NextScene")
            {
                if(Input.anyKey)
                {
                    word_mnger.ClickNext();
                }
            }
        }
    }
}
