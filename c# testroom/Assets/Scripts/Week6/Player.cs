using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum PlayerState {Angry, Tired, Sick};

    public PlayerState pState;

    private void Update()
    {
        switch (pState)
        {
            case PlayerState.Angry:
                GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case PlayerState.Tired:
                GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case PlayerState.Sick:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;
            default:
                break;
        }
    }
}
