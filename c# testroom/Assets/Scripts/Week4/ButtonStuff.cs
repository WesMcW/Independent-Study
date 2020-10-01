using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonStuff : MonoBehaviour, IPointerClickHandler
{
    public Outcomes outcome;
    public int myNum;

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (myNum)
        {
            case 1:
                outcome.DoAttack();
                break;
            case 2:
                outcome.DoRun();
                break;
            case 3:
                outcome.DoUseItem();
                break;
            case 4:
                outcome.DoHeal();
                break;
            case 5:
                outcome.DoTrap();
                break;
            default:
                outcome.DoNothing();
                break;
        }
    }
}
