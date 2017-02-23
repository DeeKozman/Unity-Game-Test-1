using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform _myTransform;
    public int maxDistance;
    public int moveSpeed;
    public int rotationSpeed;
    public Transform target;

    private void Awake()
    {
        _myTransform = transform;
    }

    // Use this for initialization
    private void Start()
    {
        var go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;

        maxDistance = 11;
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawLine(target.position, _myTransform.position, Color.yellow);
        _myTransform.rotation = Quaternion.Slerp(_myTransform.rotation,
            Quaternion.LookRotation(target.position, _myTransform.position), rotationSpeed * Time.deltaTime);

        if (Vector3.Distance(target.position, _myTransform.position) > maxDistance)
            _myTransform.position += _myTransform.forward * moveSpeed * Time.deltaTime;
    }
}