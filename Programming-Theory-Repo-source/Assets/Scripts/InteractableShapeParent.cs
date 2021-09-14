using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableShapeParent : MonoBehaviour
{
    protected string shapeName;
    protected string description;

    private int m_favoriteNumber = 10;
    protected int favoriteNumber
    {
        get { return m_favoriteNumber; }
        set
        {
            if (value < 1)
            {
                Debug.LogError("Please Insert A Number Greater Than 0");
            }
            else
            {
                m_favoriteNumber = value;
            }
        }
    }

    protected Color shapeColor;
    protected Material shapeMaterial;

    public virtual void DisplayText()
    {
        Debug.Log("Name: " + shapeName + ", ");
        Debug.Log("Description: " + description);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
