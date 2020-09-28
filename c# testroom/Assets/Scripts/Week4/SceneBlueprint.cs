using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scene", menuName = "ScriptableObjects/Scene", order = 1)]
public class SceneBlueprint : ScriptableObject
{
    public string title, desc;
    public string op1,op2,op3;

}
