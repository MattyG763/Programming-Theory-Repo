using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScript : InteractableShapeParent
{
    private string hobby = "Long Walks On The Beach";

    private void Awake()
    {
        shapeMaterial = GetComponent<MeshRenderer>().materials[0];

        shapeName = "Purple Quad";
        description = "Fun fact, the back side is invisible";

        shapeColor = Color.magenta;
        shapeMaterial.color = shapeColor;

    }

    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("Enjoies: " + hobby);
    }
}
