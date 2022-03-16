using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectUIButtonManage : UIButtonManage
{
    void Awake()
    {
        _backButton?.onClick.AddListener(Back);
        _level1Button?.onClick.AddListener(delegate{LevelSelect(2);});
        _level2Button?.onClick.AddListener(delegate{LevelSelect(3);});
        _level3Button?.onClick.AddListener(delegate{LevelSelect(4);});
        _level4Button?.onClick.AddListener(delegate{LevelSelect(5);});
        _level5Button?.onClick.AddListener(delegate{LevelSelect(6);});
    }

    void Back() => SceneManage.GoToScene(0);

    void LevelSelect(int level) => SceneManage.GoToScene(level);
}
