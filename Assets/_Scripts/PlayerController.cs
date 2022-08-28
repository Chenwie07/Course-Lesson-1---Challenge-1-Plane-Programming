using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float horizontalInput; 
    private float verticalInput; 

    // Update is called once per frame
    void Update()
    {
        // Move vehicle Forward
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // will turn left if horizontalInput is -ve. 
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput); // rotates around the up(y-axis). 
    }
}
