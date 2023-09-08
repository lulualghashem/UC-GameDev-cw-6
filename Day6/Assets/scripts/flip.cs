using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    SpriteRenderer sp;
    bool faceRight = false;
    bool Flipx = false;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         Flip();
    }
    void Flip()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            sp.flipX = false;
            faceRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            sp.flipX = true;
            faceRight = true;
        }
    }
}
