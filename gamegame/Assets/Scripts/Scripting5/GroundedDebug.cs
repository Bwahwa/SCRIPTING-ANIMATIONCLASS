using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedDebug : MonoBehaviour
{
    private CharacterController controller;
    // Start is called before the first frame update
    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
