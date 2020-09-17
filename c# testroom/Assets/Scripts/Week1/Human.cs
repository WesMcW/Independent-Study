using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Creature<int>
{
    public override void Intro(int amt, int dmg)
    {
        base.Intro(amt, dmg);

        health = amt;
        damage = dmg;

        Debug.Log("Human: Health = " + health + " Damage = " + damage);
    }
}
