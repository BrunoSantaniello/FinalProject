using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Declare variables for movement speed and input values
    float movementSpeed;
    float horiMovement;
    float verMovement;

    // Start is called before the first frame update
    void Start()
    {
        // Instructional messages in the console
        Debug.Log("Use WASD to move your character around");
        Debug.Log("Avoid obstacles at all cost");
        Debug.Log("Press L to destroy some obstacles");
        Debug.Log("Hit the last wall to go to Level 2!");
        Debug.Log("Press F5 if you want to reset.");
        Debug.Log("Good Luck :)");

        // Set the initial movement speed
        movementSpeed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        // Get input values for horizontal and vertical movement
        horiMovement = Input.GetAxis("Horizontal");
        verMovement = Input.GetAxis("Vertical");

        // Move the object based on the input values and movement speed
        transform.Translate(horiMovement * Time.deltaTime * movementSpeed, 0, 0);
        transform.Translate(0, 0, verMovement * Time.deltaTime * movementSpeed);
    }
}
