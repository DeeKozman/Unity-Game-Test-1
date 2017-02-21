using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Singleton to control the game data between scenes.
/// </summary>
namespace GameStuff.GameMgmt
{
    public class GameControl : MonoBehaviour
    {

        public static GameControl control;
        public float playerHealth;
        public float playerLevel;
        public string weaponInHand;
        public string armorOnHead;
        public string armorOnChest;
        public string armorOnFeet;

        void Awake()
        {
            if (control == null)
            {
                DontDestroyOnLoad(gameObject);
                control = this;
            }
            else if (control != this)
            {
                Destroy(gameObject);
            }
            
        }
    }

}
