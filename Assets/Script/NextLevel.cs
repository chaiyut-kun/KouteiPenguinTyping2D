using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private static string[] scene_names = {"Level1","Level2","Level3"};
    private static int scene_idx = 0;

    public static void LoadLevel() 
    {
       if (SceneManager.GetActiveScene().name.Contains("Level"))
        {
            SceneManager.LoadScene("NextScene");

        }
        else 
        {
            SceneManager.LoadScene(scene_names[++scene_idx]);
        }
            
    }
}
