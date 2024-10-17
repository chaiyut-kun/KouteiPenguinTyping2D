using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public new AudioSource audio;
    public   AudioClip typed;
    public  AudioClip typing;
    public  AudioClip wrongtyped;
    public  AudioClip jump;

    public void PlayTyped()
    {
        audio.PlayOneShot(typed);
    }

    public  void PlayTyping()
    {
        audio.PlayOneShot(typing);
    }
    
    public  void WrongTyped()
    {
        audio.PlayOneShot(wrongtyped);
    }

    public  void playJump()
    {
        audio.PlayOneShot(jump);
    }

}
