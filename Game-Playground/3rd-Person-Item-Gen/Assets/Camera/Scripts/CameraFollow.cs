using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _player; // Reference to the _player's transform.
    public Vector3 maxXAndZ; // The maximum x and y coordinates the camera can have.
    public Vector3 minXAndZ; // The minimum x and y coordinates the camera can have.
    public float xMargin = 1f; // Distance in the x axis the _player can move before the camera follows.
    public float xSmooth = 3f; // How smoothly the camera catches up with it's target movement in the x axis.
    public float zMargin = 1f; // Distance in the y axis the _player can move before the camera follows.
    public float zSmooth = 3f; // How smoothly the camera catches up with it's target movement in the y axis.


    private void Awake()
    {
        // Setting up the reference.
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private bool CheckXMargin()
    {
        // Returns true if the distance between the camera and the _player in the x axis is greater than the x margin.
        return Mathf.Abs(transform.position.x - _player.position.x) > xMargin;
    }


    private bool CheckZMargin()
    {
        // Returns true if the distance between the camera and the _player in the y axis is greater than the y margin.
        return Mathf.Abs(transform.position.z - _player.position.z) > zMargin;
    }


    private void FixedUpdate()
    {
        TrackPlayer();
    }


    private void TrackPlayer()
    {
        // By default the target x and y coordinates of the camera are it's current x and y coordinates.
        var targetX = transform.position.x;
        var targetZ = transform.position.z;

        // If the _player has moved beyond the x margin...
        if (CheckXMargin())
            // ... the target x coordinate should be a Lerp between the camera's current x position and the _player's current x position.
            targetX = Mathf.Lerp(transform.position.x, _player.position.x, xSmooth * Time.deltaTime);

        // If the _player has moved beyond the y margin...
        if (CheckZMargin())
            // ... the target y coordinate should be a Lerp between the camera's current y position and the _player's current y position.
            targetZ = Mathf.Lerp(transform.position.z, _player.position.z, zSmooth * Time.deltaTime);

        // The target x and y coordinates should not be larger than the maximum or smaller than the minimum.
        targetX = Mathf.Clamp(targetX, minXAndZ.x, maxXAndZ.x);
        targetZ = Mathf.Clamp(targetZ, minXAndZ.z, maxXAndZ.z);

        // Set the camera's position to the target position with the same z component.
        transform.position = new Vector3(targetX, transform.position.y, targetZ);
    }
}