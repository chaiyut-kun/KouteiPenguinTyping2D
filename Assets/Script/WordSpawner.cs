using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject word_prefab;
    public Transform canvas;
    public WordDisplay SpawnWord()
    {
        Vector3 random_position = new Vector3(Random.Range(-30f,30f),25f);
        
        GameObject word_obj = Instantiate(word_prefab , random_position , Quaternion.identity ,canvas);
        WordDisplay word_display = word_obj.GetComponent<WordDisplay>();
        return word_display;
    }
}
