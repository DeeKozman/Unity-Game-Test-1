using UnityEngine;
using UnityEngine.UI;

public class detectHit : MonoBehaviour
{
    private Animator anim;

    public Slider healthbar;
    public string oppenent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != oppenent) return;
        //Debug.Log("Hit!!!");
        healthbar.value -= 10;

        if (healthbar.value <= 0)
            anim.SetBool("isDead", true);
    }


    // Use this for initialization
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}