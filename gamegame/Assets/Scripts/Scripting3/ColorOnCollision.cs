using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOnCollision : MonoBehaviour
{
    public Color newColor = Color.red;
    
    public int collisionCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        collisionCount += 1;
        
        if (collisionCount == 2)
        {
            GetComponent<Renderer>().material.color = newColor;
        }
    }
    
}
