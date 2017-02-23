using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Logic for the enemy to chase and attack.
/// </summary>

namespace GameStuff.Enemy
{
    public class Chase : MonoBehaviour
    {
        private static Animator _anim;
        public Slider healthbar;
        public Transform player;

        // Use this for initialization
        private void Start()
        {
            _anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (healthbar.value <= 0) return;
            var direction = player.position - transform.position;
            var angle = Vector3.Angle(direction, transform.forward);
            if (Vector3.Distance(player.position, transform.position) < 20 && angle < 30)
            {
                direction.y = 0;

                transform.rotation = Quaternion.Slerp(transform.rotation,
                    Quaternion.LookRotation(direction), 0.1f);

                _anim.SetBool("isIdle", false);
                if (direction.magnitude > 6)
                {
                    transform.Translate(0, 0, 0.05f);
                    _anim.SetBool("isWalking", true);
                    _anim.SetBool("isAttacking", false);
                }
                else
                {
                    _anim.SetBool("isAttacking", true);
                    _anim.SetBool("isWalking", false);
                }
            }
            else
            {
                _anim.SetBool("isWalking", true);
                _anim.SetBool("isIdle", false);
                //_anim.SetBool("isIdle", true);
                // _anim.SetBool("isWalking", false);
                _anim.SetBool("isAttacking", false);
            }
        }
    }
}