using UnityEngine;
using UnityEngine.AI;

/// <summary>
///     Enemy Testing class. Will not be in final build.
/// </summary>
//TODO get rid of this before final push.
public class EnemyMovement : MonoBehaviour
{
    private Animator _anim;
    private NavMeshAgent _nav; // Reference to the nav mesh agent.
    private Transform _player; // Reference to the _player's position.

    private void Awake()
    {
        // Set up the references.
        _player = GameObject.FindGameObjectWithTag("Player").transform;

        // _nav = GetComponent<NavMeshAgent>();
    }


    private void Update()
    {
        // Set the destination of the nav mesh agent to the _player.
        // _anim.SetBool("OrcIsRunning", true);
        // _nav.SetDestination(_player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Player Hit!!!)");
    }
}