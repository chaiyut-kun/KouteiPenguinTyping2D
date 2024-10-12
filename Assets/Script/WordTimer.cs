using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;

public class WordTimer : MonoBehaviour
{
    public WordManager word_manager; 
    
    public float delay = 2f;
    private float nextword_time = 1f;

    private void Update()
    {
        if (Time.time >= nextword_time)
        {
            word_manager.Addword();
            nextword_time = Time.time + delay*2.2f;
            delay -= 0.00009f;
        }
    }

    
}
