using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator _anim;
    private Vector3 _dir;
    private float _direction;
    private float _distance;
    public float AttackTimer;
    public float CoolDown;
    public GameObject PlayerTarget;
    // Use this for initialization
    private void Start()
    {
        AttackTimer = 0;
        CoolDown = 2.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (AttackTimer > 0)
            AttackTimer -= Time.deltaTime;

        if (AttackTimer < 0)
            AttackTimer = 0;

        if (Input.GetKeyUp(KeyCode.Space))
            if (AttackTimer == 0)
            {
                // _anim.SetBool("IsRunning", false);
                MeleeAttack();

                AttackTimer = CoolDown;
            }
    }

    private void MeleeAttack()
    {
        //_anim.SetBool("IsAttacking", true);
        _distance = Vector3.Distance(PlayerTarget.transform.position, transform.position);
        _dir = (PlayerTarget.transform.position - transform.position).normalized;
        _direction = Vector3.Dot(_dir, transform.forward);
        Debug.Log("direction =" + _direction);
        Debug.Log("Enemy distance =" + _distance);
        if (_distance < 5.5f)
            if (_direction > 0)
                Debug.Log("Enemy Hit!!!");
    }

    /*_anim.SetBool("IsAttacking", false);
            _anim.SetBool("IsRunning", true);*/
}