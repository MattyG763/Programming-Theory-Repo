using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : InteractableShapeParent
{
    private void Awake()
    {
        shapeMaterial = GetComponent<MeshRenderer>().materials[0];

        shapeName = "Spongebob";
        description = "He's a Cylinder";
        shapeColor = Color.green;
        shapeMaterial.color = shapeColor;
    }
}
