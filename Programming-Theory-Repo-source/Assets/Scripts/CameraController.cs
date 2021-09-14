using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float speed = 5;
    private float rotationSpeed = 100;
    private Vector3 direction;

    void GetMovement()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        transform.Translate(direction * speed * Time.deltaTime);
    }

    void GetRotation()
    {
        float yRotation = 0;

        if (Input.GetKey(KeyCode.E))
        {
            //Rotate Right
            yRotation = 1;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            //Rotate Left
            yRotation = -1;
        }

        transform.Rotate(new Vector3(transform.rotation.x, yRotation * rotationSpeed * Time.deltaTime, transform.rotation.z));
    }

    void Update()
    {
        GetMovement();
        GetRotation();
    }
}
