using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideTest : MonoBehaviour
{
    Human h = new Human();
    Orc o = new Orc();

    //Human
    public void SetHealthHuman(string hp)
    {
        h.health = int.Parse(hp);
    }

    public void SetDamageHuman(string dmg)
    {
        h.damage = int.Parse(dmg);
    }

    public void HumanInro()
    {
        h.Intro(h.health, h.damage);
    }

    //Orc
    public void SetHealthOrc(string hp)
    {
        o.health = int.Parse(hp);
    }

    public void SetDamageOrc(string dmg)
    {
        o.damage = int.Parse(dmg);
    }

    public void OrcIntro()
    {
        o.Intro(o.health, o.damage);
    }
}
