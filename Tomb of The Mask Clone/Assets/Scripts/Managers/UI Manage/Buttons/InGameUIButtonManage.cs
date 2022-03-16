using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUIButtonManage : UIButtonManage
{
    void Awake()
    {
        _pauseButton.onClick.AddListener(Pause);
        _resumeButton.onClick.AddListener(Resume);
        _restartButtonPauseMenu.onClick.AddListener(Restart);
        _mainMenuButtonPauseMenu.onClick.AddListener(MainMenu);

        _restartButtonLevelOverMenu.onClick.AddListener(Restart);
        _mainMenuButtonLevelOverMenu.onClick.AddListener(MainMenu);
        _nextLevelButton.onClick.AddListener(NextLevel);

        _restartButtonGameOverMenu.onClick.AddListener(Restart);
        _mainMenuButtonGameOverMenu.onClick.AddListener(MainMenu);
    }

    void Pause() => SceneManage.PauseGame();

    void Resume() => SceneManage.ResumeGame();

    void Restart() => SceneManage.RestartGame();

    void MainMenu() => SceneManage.GoToScene(0);

    void NextLevel() => SceneManage.NextLevel();

    
}
