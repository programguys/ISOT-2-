using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controllnice : MonoBehaviour {
    

   private Mousecontrol mousecontrol;
    public float range = 5f, moveSpeed = 3f, TurnSpeed = 40f;

    public int JumpForce;
    public bool IsGround;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
           transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
        }
        Jump();
       
    }

    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast (ray, out rh, 0.5f))
        {
            IsGround = true;
        }
        else
        {
            IsGround = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGround)
        {
            rb.AddForce(Vector3.up * JumpForce);
        }
    }
}
