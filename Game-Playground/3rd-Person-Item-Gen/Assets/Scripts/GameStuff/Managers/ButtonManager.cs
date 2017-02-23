using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameStuff.Managers
{
    [Serializable]
    public class ButtonManager : MonoBehaviour
    {
        public static ButtonManager ButtonMgr;


        private void Awake()
        {
            if (ButtonMgr != null)
            {
                Destroy(gameObject);
            }
            else if (ButtonMgr == this)
            {
                DontDestroyOnLoad(gameObject);
                ButtonMgr = this;
            }
        }

        public void NewGameBtn(int newGameLevel)
        {
            SceneManager.LoadScene(newGameLevel);
        }

        public void ExitGameBtn()
        {
            Application.Quit();
        }
    }
}