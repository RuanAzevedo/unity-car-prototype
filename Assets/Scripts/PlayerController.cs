using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15;
    private float turnSpeed = 65.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    private void Update()
    {
        // Moves the car forward based on vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Rotates the car based on horizontal input
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
