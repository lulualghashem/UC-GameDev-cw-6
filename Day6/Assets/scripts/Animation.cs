using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
{
    Animator anim;
    bool Canjump;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Canjump ==  true && Input.GetKeyDown(KeyCode.Space))
        {
            Canjump = false;
            anim.SetBool("Jump", true);
            anim.SetBool("Run", false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor" && Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            Canjump = true;
            anim.SetBool("Jump", false);
            anim.SetBool("Run", true);
        }
        else if (collision.gameObject.tag == "Floor" && Input.anyKeyDown == false)
        {
            Canjump = true;
            anim.SetBool("Jump", false);
            anim.SetBool("Run", false);
        }
    }
}
