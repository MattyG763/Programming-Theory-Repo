using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : InteractableShapeParent
{
    private void Awake()
    {
        shapeMaterial = GetComponent<MeshRenderer>().materials[0];

        shapeName = "Red Cube";
        description = "Is a bit edgy";
        favoriteNumber = 25;

        shapeColor = Color.red;
        shapeMaterial.color = shapeColor;
    }

    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("Favorite Number Is: " + favoriteNumber);
    }
}
