using System;
using UnityEngine;

/// <summary>
/// Singleton to control the game data between scenes.
/// </summary>

namespace GameStuff.Managers
{
    [Serializable]
    public class GameControl : MonoBehaviour
    {
        public static GameControl control;
        public string armorOnChest;
        public string armorOnFeet;
        public string armorOnHead;

        public float playerHealth;
        public float playerLevel;
        public string weaponInHand;

        private void Awake()
        {
            if (control != null)
            {
                Destroy(gameObject); //if scene has a game control, kill it.
            }
            else if (control == this)
            {
                DontDestroyOnLoad(gameObject); //persist past scene loads and restarts!
                control = this;
            }
        }
    }
}