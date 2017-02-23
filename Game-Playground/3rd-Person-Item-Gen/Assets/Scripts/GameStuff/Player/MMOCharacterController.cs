using UnityEngine;

/// <summary>
/// Improved Character Controller class. Still not great.
/// </summary>

namespace GameStuff.Player
{
    public class MMOCharacterController : MonoBehaviour
    {
        public Transform centerPoint;
        public float mouseSensitivity = 10f;

        private float mouseX;
        private float mouseY;
        public float mouseYPosition = 1f;

        private float moveFB;
        private float moveLR;
        public float moveSpeed = 2f;
        public Transform player;

        public Transform playerCam;

        public float rotationSpeed = 5f;

        private float zoom;
        public float zoomMax = -10f;

        public float zoomMin = -2f;
        public float zoomSpeed = 2;


        // Use this for initialization
        private void Start()
        {
            zoom = -3;
        }

        // Update is called once per frame
        private void Update()
        {
            zoom += Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

            if (zoom > zoomMin)
                zoom = zoomMin;

            if (zoom < zoomMax)
                zoom = zoomMax;

            playerCam.transform.localPosition = new Vector3(0, 0, zoom);

            if (Input.GetMouseButton(1))
            {
                mouseX += Input.GetAxis("Mouse X");
                mouseY -= Input.GetAxis("Mouse Y");
            }

            mouseY = Mathf.Clamp(mouseY, -60f, 60f);
            playerCam.LookAt(centerPoint);
            centerPoint.localRotation = Quaternion.Euler(mouseY, mouseX, 0);

            moveFB = Input.GetAxis("Vertical") * moveSpeed;
            moveLR = Input.GetAxis("Horizontal") * moveSpeed;

            var movement = new Vector3(moveLR, 0, moveFB);
            movement = player.rotation * movement;
            //player.GetComponent<CharacterController>().Move(movement * Time.deltaTime);///TODO:Something is broken.
            centerPoint.position = new Vector3(player.position.x, player.position.y + mouseYPosition, player.position.z);

            if ((Input.GetAxis("Vertical") >= 0) | (Input.GetAxis("Vertical") < 0))
            {
                var turnAngle = Quaternion.Euler(0, centerPoint.eulerAngles.y, 0);

                player.rotation = Quaternion.Slerp(player.rotation, turnAngle, Time.deltaTime * rotationSpeed);
            }
        }
    }
}