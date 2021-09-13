using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeClass : CubeBaseClass
{

    private void Awake()
    {
        speed = 2;
        cubeMaterial = GetComponent<MeshRenderer>().materials[0];

        cubeName = "Red Cube";
        cubeColor = Color.red;
        cubeMaterial.color = cubeColor;

        DisplayNameToConsole();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = 5;
        }

        MoveForward(speed);
    }
}
