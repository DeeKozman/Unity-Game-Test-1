using UnityEngine;

public class CameraController : MonoBehaviour
{
    private readonly float _distance = 3; // starting distance away from player.
    private readonly int _lerpRate = 5;

    private readonly int _mouseXSpeedMod = 5;
    private readonly int _mouseYSpeedMod = 3;
    private float _correctedDistance; // used for calculations.

    private float _currentDistance;
    private float _desiredDistance; // used for calculations.
    public Transform cameraTarget;

    public float cameraTargetHeight = 1.0f;
    public float maxViewDistance = 25; // how far camera will zoom out.
    public float minViewDistance = 1; // how close camera will zoom in.

    private float x;
    private float y;
    public int zoomRate = 30; // how fast camera will zoom.

    // Use this for initialization
    private void Start()
    {
        var angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;

        _currentDistance = _distance;
        _desiredDistance = _distance;
        _correctedDistance = _distance;
    }


    // Function which happens AFTER the Update function. We want player movement to happen first.
    private void LateUpdate()
    {
        if (Input.GetMouseButton(0)) // 0 = left mouse button or 1 = right mouse button.
        {
            x += Input.GetAxis("Mouse X") * _mouseXSpeedMod;
            y += Input.GetAxis("Mouse Y") * _mouseYSpeedMod;
        }
        else if
            (Input.GetAxis("Vertical") != 0.0f || Input.GetAxis("Horizontal") != 0.0f)
            // if either vertical or horizontal buttons are pressed then the code below will execute.
        {
            var targetRotationAngle = cameraTarget.eulerAngles.y;
            var cameraRotationalAngle = transform.eulerAngles.y;
            x = Mathf.LerpAngle(cameraRotationalAngle, targetRotationAngle, _lerpRate * Time.deltaTime);
        }

        y = ClampAngle(y, -50, 80);

        var rotation = Quaternion.Euler(y, x, 0);

        _desiredDistance -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * zoomRate * Mathf.Abs(_desiredDistance);
        //Calculates the distance the player wants the Camera.
        _desiredDistance = Mathf.Clamp(_desiredDistance, minViewDistance, maxViewDistance);
        _correctedDistance = _desiredDistance;

        var position = cameraTarget.position - rotation * Vector3.forward * _desiredDistance;
        //(x,y,z) * (0,1,0) * (angle in degrees).

        RaycastHit collisionHit;
        var CameraTargetPosition = new Vector3(cameraTarget.position.x, cameraTarget.position.y + cameraTargetHeight,
            cameraTarget.position.z);

        var isCorrected = false;
        if (Physics.Linecast(CameraTargetPosition, position, out collisionHit))
        {
            position = collisionHit.point;
            _correctedDistance = Vector3.Distance(CameraTargetPosition, position);
            isCorrected = true;
        }

        //?: conditional 
        //condition ? first_expression : second_expression;

        _currentDistance = !isCorrected || _correctedDistance > _currentDistance
            ? Mathf.Lerp(_currentDistance, _correctedDistance, Time.deltaTime * zoomRate)
            : _correctedDistance;

        position =
            cameraTarget.position =
                rotation * Vector3.forward * _currentDistance + new Vector3(0, -cameraTargetHeight, 0);

        transform.rotation = rotation;
        transform.position = position;
    }

    private static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}