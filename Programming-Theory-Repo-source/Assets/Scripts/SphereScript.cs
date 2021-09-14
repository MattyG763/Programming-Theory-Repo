using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : InteractableShapeParent
{
    private string favoriteFood = "Tacos";

    private void Awake()
    {
        shapeMaterial = GetComponent<MeshRenderer>().materials[0];

        shapeName = "Blue Sphere";
        description = "Smooth as silk";
        favoriteNumber = 68;

        shapeColor = Color.blue;
        shapeMaterial.color = shapeColor;

    }

    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("Favorite Food: " + favoriteFood);
    }
}
