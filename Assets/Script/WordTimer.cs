using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;

public class WordTimer : MonoBehaviour
{
    public WordManager word_manager; 
    
    public float delay = 1f;
    private float nextword_time = 1f;

    private void Update()
    {
        if (Time.time >= nextword_time)
        {
            word_manager.Addword();
            nextword_time = Time.time + delay*2.5f;
            delay -= 0.09f;
        }
    }

    
}
