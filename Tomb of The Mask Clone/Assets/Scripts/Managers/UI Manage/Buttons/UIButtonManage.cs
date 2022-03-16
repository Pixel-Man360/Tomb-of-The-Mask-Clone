using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonManage : MonoBehaviour
{
    [Header("All buttons in the given scene:")]

    [Header("Main Menu Buttons: ")]

    [SerializeField] protected Button _playButton;
    [SerializeField] protected Button _exitButton;

    [Header("Level Selector Buttons: ")]

    [SerializeField] protected Button _backButton;
    [SerializeField] protected Button _level1Button;
    [SerializeField] protected Button _level2Button;
    [SerializeField] protected Button _level3Button;
    [SerializeField] protected Button _level4Button;
    [SerializeField] protected Button _level5Button;
     
    [Header("In Game Buttons: ")]

    [Header("Pause Menu:")]
    [SerializeField] protected Button _pauseButton;
    [SerializeField] protected Button _resumeButton;
    [SerializeField] protected Button _restartButtonPauseMenu;
    [SerializeField] protected Button _mainMenuButtonPauseMenu;
   
    [Header("Level Over Menu:")]
    [SerializeField] protected Button _restartButtonLevelOverMenu;
    [SerializeField] protected Button _nextLevelButton;
    [SerializeField] protected Button _mainMenuButtonLevelOverMenu;

    [Header("Game Over Menu")]
    [SerializeField] protected Button _restartButtonGameOverMenu;
    [SerializeField] protected Button _mainMenuButtonGameOverMenu;



}
