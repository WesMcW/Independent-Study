using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encounter : MonoBehaviour
{
    public SceneBlueprint sceneInfo;
    public Text titleText, descText, op1Text, op2Text, op3Text;
    void Start()
    {
        SceneSetup();
    }

    void SceneSetup()
    {
        titleText.text = sceneInfo.title;
        descText.text = sceneInfo.desc;
        op1Text.text = sceneInfo.op1;
        op2Text.text = sceneInfo.op2;
        op3Text.text = sceneInfo.op3;
    }
}
