using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelManage : MonoBehaviour
{
    [Header("All GameObjects To be hidden or Shown")]
    [SerializeField] private GameObject _pauseButton;

    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _levelOverMenu;
    [SerializeField] private GameObject _gameOverMenu;


    void Awake() 
    {
        _pauseButton.SetActive(true);
        _pauseMenu.SetActive(false);
        _levelOverMenu.SetActive(false);
        _gameOverMenu.SetActive(false);
    }

    void OnEnable() 
    {
        Observer.onGamePaused += HideOrShowPauseMenu;
        Observer.onLevelOver += HideLevelOverMenu;
        Observer.onGameOver += HideGameOverMenu;
    }

    void OnDisable() 
    {
        Observer.onGamePaused -= HideOrShowPauseMenu;
        Observer.onLevelOver -= HideLevelOverMenu;
        Observer.onGameOver -= HideGameOverMenu;
    }



    void HideOrShowPauseButton(bool set)
    {
        _pauseButton.SetActive(set);
    }

    void HideOrShowPauseMenu(bool set)
    {
        _pauseMenu.SetActive(set);

        HideOrShowPauseButton(!set);
    }

    void HideLevelOverMenu() 
    {
        _levelOverMenu.SetActive(true); 
        HideOrShowPauseButton(false);
    }

    void HideGameOverMenu()
    {
        _gameOverMenu.SetActive(true); 
        HideOrShowPauseButton(false);
    }




}
