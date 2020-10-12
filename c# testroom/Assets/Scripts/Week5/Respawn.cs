using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public bool dead;
    DelegateTest.MultiUse test;

    private void Start()
    {
        test += CountUp;
        DelegateTest.single += TurnOn;
    }

    private void Update()
    {
        if (dead)
        {
            TurnOff();
        }
    }

    public void TurnOff()
    {
        gameObject.SetActive(false);
        if (test != null)
        {
            test();
        }
    }

    public void CountUp()
    {
        DelegateTest.myNum++;
        print(DelegateTest.myNum);
    }

    public void TurnOn()
    {
        gameObject.SetActive(true);
        dead = false;
    }
}
