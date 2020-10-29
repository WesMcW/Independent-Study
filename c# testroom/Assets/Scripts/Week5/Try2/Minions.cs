using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour
{
    public delegate void Alive();
    public static event Alive MinionAlive;

    public delegate void Dead();
    public static event Dead MinionDead;

    void Start()
    {
        MinionAlive();
    }

    private void OnDestroy()
    {
        MinionDead();
    }
}
