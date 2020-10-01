using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Encounter", menuName = "ScriptableObjects/Encounter", order = 1)]
public class SceneBlueprint : ScriptableObject
{
    public string title, desc;

    public string op1;
    public optionOutcome option1;
    public string op2;
    public optionOutcome option2;
    public string op3;
    public optionOutcome option3;
}
