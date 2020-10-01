﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Encounter", menuName = "ScriptableObjects/Encounter", order = 1)]
public class SceneBlueprint : ScriptableObject
{
    public string title, desc;

    [Header("Outcomes: 0=Nothing | 1=Attack | 2=Run | 3=UseItem | 4=Heal | 5=Trap")]
    public string op1;
    public int option1Outcome;
    public string op2;
    public int option2Outcome;
    public string op3;
    public int option3Outcome;
}
