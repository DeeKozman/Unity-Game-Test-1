using UnityEngine;

/// <summary>
/// TODO: Get all character controllers and movement classes refined.
/// </summary>

namespace GameStuff.Player
{
    public class CharacterMovement : MonoBehaviour
    {
        private Animator anim;

        private Vector3 movement;
        private Rigidbody playerRigidbody;
        public float speed = 6f; //The speed that the player will move.
        private Vector3 turning;
        public float turnSmoothing = 15f;
        public float turnSpeed = 60f;

        private void Awake()
        {
            //Get references
            anim = GetComponent<Animator>();
            playerRigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            //Store input axes
            var lh = Input.GetAxisRaw("Horizontal");
            var lv = Input.GetAxisRaw("Vertical");

            Move(lh, lv);

            Animating(lh, lv);
        }

        private void Move(float lh, float lv)
        {
            //Move the player
            movement.Set(lh, 0f, lv);

            //movement = movement.normalized * speed * Time.deltaTime;

            //playerRigidbody.MovePosition(transform.position + movement);

            if (lh != 0f || lv != 0f)
                Rotating(lh, lv);
        }

        private void Rotating(float lh, float lv)
        {
            var targetDirection = new Vector3(lh, 0f, lv);

            var targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);

            var newRotation = Quaternion.Lerp(GetComponent<Rigidbody>().rotation, targetRotation,
                turnSmoothing * Time.deltaTime);

            GetComponent<Rigidbody>().MoveRotation(newRotation);
        }

        private void Animating(float lh, float lv)
        {
            var running = lh != 0f || lv != 0f;

            // anim.SetBool("IsRunning", running);
        }
    }
}