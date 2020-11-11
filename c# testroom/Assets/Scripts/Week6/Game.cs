using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public enum GameState {Paused, Active, GameOver};

    public GameState gState;
}
