using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Creature<int>
{
    public override void Intro(int amt, int dmg)
    {
        base.Intro(amt, dmg);

        health = amt;
        damage = dmg;

        Debug.Log("Orc: Health = " + health + " Damage = " + damage);
    }
}
