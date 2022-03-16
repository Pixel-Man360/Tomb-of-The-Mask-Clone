using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUIButtonManage : UIButtonManage
{
    void Awake() 
    {
        _playButton?.onClick.AddListener(SelectLevel);
        _exitButton?.onClick.AddListener(Exit);
    }

    void SelectLevel() => SceneManage.GoToScene(1);
    
    void Exit() => SceneManage.ExitGame();
}
