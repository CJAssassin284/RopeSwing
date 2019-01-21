using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingContact : MonoBehaviour
{
    public bool canGrab = false;
    public Transform grabObj;
    public Vector3 offset;


    bool grabbed;
    private void Update()
    {
        //If touch when near rope allow to grab.
        if(canGrab)
        {
            if(Input.GetMouseButtonDown(0))
            {
                grabbed = true;
            }
        }

        //If the player is on the rope
        if(grabbed)
        {
                transform.position = grabObj.transform.position + offset;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Detects if we are colliding with the rope.
        if(collision.gameObject.CompareTag("Rope"))
        {
            canGrab = true;
            grabObj = collision.transform;
        }
    }

}
