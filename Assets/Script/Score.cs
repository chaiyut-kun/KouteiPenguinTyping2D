using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score 
{
    private static int score = 0;

    public static int GetScore()
    {
        return score;
        
    }
    
    public static void Increse()
    {
        score+=10;
    }
    public static void SetScore(int _score)
    {
        score = _score;
    }
}
