using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public enum GameState {Active, Paused, GameOver};

    public GameState gState;

    public GameObject paused, gameover;

    private void Update()
    {
        if (gState == GameState.Active)
        {
            Time.timeScale = 1;
        }
    }

    public void PauseGame()
    {
        gState = GameState.Paused;
        Time.timeScale = 0;
        paused.SetActive(true);
        gameover.SetActive(false);
    }

    public void GameOver()
    {
        gState = GameState.GameOver;
        Time.timeScale = 0;
        gameover.SetActive(true);
        paused.SetActive(false);
    }

    public void Resume()
    {
        gameover.SetActive(false);
        paused.SetActive(false);
        gState = GameState.Active;
    }
}
