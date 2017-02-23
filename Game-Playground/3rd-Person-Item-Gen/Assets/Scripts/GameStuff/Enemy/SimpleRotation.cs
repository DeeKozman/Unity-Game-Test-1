using UnityEngine;

namespace GameStuff.Enemy
{
    public class SimpleRotation : MonoBehaviour
    {
        public Transform obj;
        public float Speed = 2f;

        private void Start()
        {
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            obj.Rotate(new Vector3(0, Speed, 0));
        }
    }
}