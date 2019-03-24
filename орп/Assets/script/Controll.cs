using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {
    public float speed = 1f;

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 )
        {
            transform.Translate(transform.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(-transform.right* speed);
        }


        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(transform.forward * speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(-transform.forward * speed);
        }

    }


}
