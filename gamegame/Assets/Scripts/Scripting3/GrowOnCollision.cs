using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowOnCollision : MonoBehaviour
{
    public float growFactor = 1.9f;
    void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= growFactor;
    }

}    