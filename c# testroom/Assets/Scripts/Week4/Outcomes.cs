using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outcomes : MonoBehaviour
{
    public delegate void MyDelegate();

    public MyDelegate myDel;

    public void DoAttack()
    {
        Debug.Log("Attack!");
    }
    public void DoRun()
    {
        Debug.Log("Run!");
    }
    public void DoUseItem()
    {
        Debug.Log("Item Used!");
    }
    public void DoHeal()
    {
        Debug.Log("Used Heal!");
    }
    public void DoNothing()
    {
        Debug.Log("Nothing happened.");
    }
}
