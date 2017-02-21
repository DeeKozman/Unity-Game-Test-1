using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public static ButtonManager ButtonMgr;
    

    void Awake()
    {
        if (ButtonMgr == null)
        {
            DontDestroyOnLoad(gameObject);
            ButtonMgr = this;
        }
        else if (ButtonMgr != this)
        {
            Destroy(gameObject);
        }

    }

    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
