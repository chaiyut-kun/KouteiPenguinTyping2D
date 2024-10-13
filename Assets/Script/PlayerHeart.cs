using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class PlayerHeart 
{
    private static int health = 50;


    public static void SetHealth(int _health)
    {
        health = _health;
    }
    public static int GetHealth()
    {
        return health;
    }

    public static bool IsAlive()
    {
        if (health <= 0)
        {
            return false;
        }
        return true;
    }
    
    public static void Reset()
    {
        health = 10;
    }
    
}
