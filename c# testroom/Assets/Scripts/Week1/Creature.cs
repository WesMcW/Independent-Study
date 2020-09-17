using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Creature<T> : MonoBehaviour
{
    public int health = 0;
    public int damage = 0;

    public virtual void Intro(T hp, int dmg)
    {
        Debug.Log("Greetings");
    }
}
