using UnityEngine;
using UnityEngine.UI;

public class chase : MonoBehaviour
{
    private static Animator anim;
    public Slider healthbar;
    public Transform player;

    // Use this for initialization
    private void Start()
    {
        anim = GetComponent<Animator>();
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

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 6)
            {
                transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
            }
        }
        else
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
            //anim.SetBool("isIdle", true);
            // anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
    }
}