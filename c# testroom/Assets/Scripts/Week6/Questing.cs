using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questing : MonoBehaviour
{
    public enum QuestType {Killing, Gathering, Traveling};

    public QuestType Quest;

    public Sprite icon1, icon2, icon3;


    public void PickQuest()
    {
        int rand = Random.Range(1, 4);

        if(rand == 1)
        {
            Quest = QuestType.Killing;
            GetComponent<SpriteRenderer>().sprite = icon1;
        }
        else if(rand == 2)
        {
            Quest = QuestType.Gathering;
            GetComponent<SpriteRenderer>().sprite = icon2;
        }
        else
        {
            Quest = QuestType.Traveling;
            GetComponent<SpriteRenderer>().sprite = icon3;
        }

    }
}
