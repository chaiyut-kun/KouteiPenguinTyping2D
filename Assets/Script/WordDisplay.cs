using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WordDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    private float fall_speed = 10f;
    public void Setword(string word)
    {
        text.text = word;
		IncreaseSpeed();
    }
    
    public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

    public void RemoveWord ()
	{
		Destroy(gameObject);
	}

    private void Update()
	{
		transform.Translate(0f, -fall_speed * Time.deltaTime, 0f);
	}
	private void IncreaseSpeed()
    {
		fall_speed += 0.025f;
    }
    
}
