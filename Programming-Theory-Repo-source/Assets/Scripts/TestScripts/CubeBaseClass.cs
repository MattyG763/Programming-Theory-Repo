using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBaseClass : MonoBehaviour
{
    protected string cubeName = "Name Of Cube";
    protected Material cubeMaterial;
    protected Color cubeColor;

    private float m_speed = 1f;
    protected float speed
    {
        get { return m_speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Speed should not be set to a negative number");
            }
            else
            {
                m_speed = value;
            }
        }
    }

    public void DisplayNameToConsole()
    {
        Debug.Log(cubeName + " was created");
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void MoveForward(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveBackward()
    {
        transform.Translate(Vector3.back * Time.deltaTime);
    }

    public void MoveBackward(float speed)
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
