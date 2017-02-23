using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class that works with both the player and the enemy. Great for this simulation, probably too simple to stand on it owns for a bigger game.
/// </summary>

namespace GameStuff.UI
{
    public class DetectHit : MonoBehaviour
    {
        private Animator _anim;

        public Slider healthbar;
        public string Opponent;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag != Opponent) return;
            //Debug.Log("Hit!!!");
            healthbar.value -= 10;

            if (healthbar.value <= 0)
                _anim.SetBool("isDead", true);
        }


        // Use this for initialization
        private void Start()
        {
            _anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}