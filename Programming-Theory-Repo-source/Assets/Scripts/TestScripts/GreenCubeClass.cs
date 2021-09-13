using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubeClass : CubeBaseClass
{
    private void Awake()
    {
        cubeMaterial = GetComponent<MeshRenderer>().materials[0];

        cubeName = "Green Cube";
        cubeColor = Color.green;
        cubeMaterial.color = cubeColor;

        DisplayNameToConsole();
    }

    private void Update()
    {
        MoveBackward(speed);
    }
}
