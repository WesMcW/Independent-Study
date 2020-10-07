using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public bool dead;

    private void Start()
    {
        DelegateTest.multi += TurnOff;
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
    }
}
