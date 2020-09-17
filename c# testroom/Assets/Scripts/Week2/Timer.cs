using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image cd;

    public void UseSkill(float coolDownTime)
    {
        cd.GetComponent<Image>().fillAmount--;
        StartCoroutine("Cooldown", coolDownTime);
    }

    //Make time param
    IEnumerator Cooldown(float time)
    {
        float currTime = 0;

        //Check time
        while (currTime < time)
        {
            currTime += Time.deltaTime;
            cd.GetComponent<Image>().fillAmount = currTime / time;
            yield return null;
        }
    }
}
