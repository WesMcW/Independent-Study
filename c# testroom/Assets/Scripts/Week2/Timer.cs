using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image cd;
    public bool pressed;

    public void UseSkill(float coolDownTime)
    {
        if (!pressed)
        {
            cd.GetComponent<Image>().fillAmount--;
            StartCoroutine("Cooldown", coolDownTime);
        }
    }

    IEnumerator Cooldown(float time)
    {
        float currTime = 0;

        //Check time
        while (currTime < time)
        {
            currTime += Time.deltaTime;
            cd.GetComponent<Image>().fillAmount = currTime / time;
            pressed = true;
            yield return null;
        }

        pressed = false;
    }
}
