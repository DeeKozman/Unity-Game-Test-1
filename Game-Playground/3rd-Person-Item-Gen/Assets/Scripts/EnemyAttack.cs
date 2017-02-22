using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Animator _anim;
    private Vector3 _dir;
    private float _direction;
    private float _distance;
    public float EnemyAttackTimer;
    public float EnemyCoolDown;
    public GameObject EnemyTarget;
    // Use this for initialization
    private void Start()
    {
        EnemyAttackTimer = 0;
        EnemyCoolDown = 2.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (EnemyAttackTimer > 0)
            EnemyAttackTimer -= Time.deltaTime;

        if (EnemyAttackTimer < 0)
            EnemyAttackTimer = 0;


        if (EnemyAttackTimer == 0)
            if (_distance < 7.5f)
            {
                Attack();
                EnemyAttackTimer = EnemyCoolDown;
            }
    }

    private void Attack()
    {
        // _anim.SetBool("OrcIsRunning", false);
        // _anim.SetBool("OrcIsAttacking", true);
        _distance = Vector3.Distance(EnemyTarget.transform.position, transform.position);
        _dir = (EnemyTarget.transform.position - transform.position).normalized;
        _direction = Vector3.Dot(_dir, transform.forward);
        // _anim.SetBool("OrcIsRunning", true);
        Debug.Log("Player distance =" + _distance);
        if (_distance < 5.5f)
            if (_direction > 0)
                Debug.Log("Enemy Hit!!!");
    }
}