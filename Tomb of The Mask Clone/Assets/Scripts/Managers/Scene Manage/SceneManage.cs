using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class SceneManage 
{

    public static void GoToScene(int sceneIndex)
    {
        TimeManage.ChangeTimeScale(1);
        sceneIndex = (sceneIndex < 7)? sceneIndex : 0;
        SceneManager.LoadSceneAsync(sceneIndex);
    }

    public static void NextLevel()
    {
        GoToScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void RestartGame()
    {
        TimeManage.ChangeTimeScale(1);
        GoToScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void PauseGame()
    {
        TimeManage.ChangeTimeScale(0);
        Observer.OnGamePaused(true);
    }

    public static void ResumeGame()
    {
        TimeManage.ChangeTimeScale(1);
        Observer.OnGamePaused(false);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }

}
