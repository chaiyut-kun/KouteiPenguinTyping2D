using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngineInternal;

public class MainScene : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start ()
    {
        animator.SetBool("Typing",true);
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void Quit()
    {
        Application.Quit();
    }

}
