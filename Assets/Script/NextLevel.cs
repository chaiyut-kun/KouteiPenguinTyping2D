using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // private static int lvlToLoad = 1;    

    public static void LoadLevel() 
    {
       if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("NextScene");

        }
        else {
            SceneManager.LoadScene("Level2");

        }
            
    }
}
