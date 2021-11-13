using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private Rigidbody rigidbodyComponent;
    private float horizontalInput;
    private float verticalInput;



    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        rigidbodyComponent.velocity = new Vector3(horizontalInput * 5, rigidbodyComponent.velocity.y, 0);
        rigidbodyComponent.velocity += new Vector3(0, 0, verticalInput * 5);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        if (jumpKeyWasPressed == true)
        {
            rigidbodyComponent.AddForce(Vector3.up * 4, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
        
    }
}
