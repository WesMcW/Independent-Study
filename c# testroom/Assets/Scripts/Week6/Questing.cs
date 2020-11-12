using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questing : MonoBehaviour
{
    public enum QuestType {Killing, Gathering, Traveling};

    public QuestType Quest;

    public Sprite icon1, icon2, icon3;

    private void Update()
    {
        if (Quest == QuestType.Killing)
            GetComponent<SpriteRenderer>().sprite = icon1;
        else if (Quest == QuestType.Gathering)
            GetComponent<SpriteRenderer>().sprite = icon2;
        else if (Quest == QuestType.Traveling)
            GetComponent<SpriteRenderer>().sprite = icon3;
    }
}
