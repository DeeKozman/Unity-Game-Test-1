using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static Animator anim;
    public float speed = 4.0F;

    // Use this for initialization
    private void Start()
    {
        anim = GetComponent<Animator>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        var translation = Input.GetAxis("Vertical") * speed;
        var straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            anim.SetBool("isAttacking", true);
        else
            anim.SetBool("isAttacking", false);

        if (translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);
        }

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}