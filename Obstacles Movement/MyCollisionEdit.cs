using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCollisionEdit : MonoBehaviour
{
    // Serialized field to allow movement speed adjustment in the Unity Editor
    [SerializeField]
    private float movementSpeed = 2f;

    // Boolean variable to track collision status
    private bool isitColliding;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize isitColliding to false at the start
        isitColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If not colliding, move the object forward
        if (isitColliding == false)
        {
            transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime);
        }

        // If colliding, move the object backward
        if (isitColliding == true)
        {
            transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
        }
    }

    // Called when a collision occurs with another object
    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has the tag "WallNorth" or "Hit"
        if (other.gameObject.CompareTag("WallNorth") || other.gameObject.CompareTag("Hit"))
        {
            // Set isitColliding to true
            isitColliding = true;
            // Move the object to the same position (0, 0, 0)
            transform.position += new Vector3(0, 0, 0);
        }

        // Check if the colliding object has the tag "WallSouth" or "Hit"
        if (other.gameObject.CompareTag("WallSouth") || other.gameObject.CompareTag("Hit"))
        {
            // Set isitColliding to false
            isitColliding = false;
            // Move the object to the same position (0, 0, 0)
            transform.position += new Vector3(0, 0, 0);
        }
    }
}
