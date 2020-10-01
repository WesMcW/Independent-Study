using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonStuff : MonoBehaviour, IPointerClickHandler
{
    public Outcomes outcome;
    public int myNum;

    public optionOutcome myOutcome;
    public void OnPointerClick(PointerEventData eventData)
    {
        switch (myOutcome)
        {
            case optionOutcome.attack:
                outcome.DoAttack();
                break;
            case optionOutcome.run:
                outcome.DoRun();
                break;
            case optionOutcome.trap:
                outcome.DoTrap();
                break;
            default:
                outcome.DoNothing();
                break;
        }
    }
}
