using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenu, PauseMenu, Gameplay;

    private void Awake()
    {
        DissableAllUIPanels();

        MainMenu.SetActive(true);
    }

    public void EnablePause()
    {
        DissableAllUIPanels();

        PauseMenu.SetActive(true);
    }

    public void EnableMainMenu()
    {
        DissableAllUIPanels();

        MainMenu.SetActive(true);
    }

    public void EnableGameplay()
    {
        DissableAllUIPanels();

        Gameplay.SetActive(true);
    }

    public void DissableAllUIPanels()
    {
        MainMenu.SetActive(false);
        PauseMenu.SetActive(false);
        Gameplay.SetActive(false);
    }
}