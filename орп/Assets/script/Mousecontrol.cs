using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousecontrol : MonoBehaviour
{
    public float sensitiveX = 3f;
    public float sensitiveY = 3f;


    private float minX = -180;
    private float maxX = 180;
    private float minY = -60;
    private float maxY = 60;
    private Quaternion originalRot;
    private float rotX = 0;
    private float rotY = 0;
    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.freezeRotation = true;
        }
        originalRot = transform.localRotation;
    }
    private void Update()
    {
        
        rotX += Input.GetAxis("Mouse X") * sensitiveX;
        rotY += Input.GetAxis("Mouse Y") * sensitiveY;

        rotY = rotY % 360;
        rotX = rotX % 360;

        rotX = Mathf.Clamp(rotX, minX, maxX);
        rotY = Mathf.Clamp(rotY, minY, maxY);

        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, Vector3.left);

        transform.localRotation = originalRot * xQuaternion * yQuaternion;

        
    }




}