using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameStateManager;

public class ButtonManager : MonoBehaviour
{
    public GameManager gameManager;

    public void PlayB()
    {
        gameManager.StateManager.ChangeState(GameState.Gameplay_State);
    }

    public void QuitB()
    {
        Application.Quit();
    }

    public void PauseB()
    {
        gameManager.StateManager.ChangeState(GameState.Paused_State);
    }

    public void MainMenuB()
    {
        gameManager.StateManager.ChangeState(GameState.MainMenu_State);
    }

    public void ResumeB()
    {
        gameManager.StateManager.ChangeState(GameState.Gameplay_State);
    }
}
