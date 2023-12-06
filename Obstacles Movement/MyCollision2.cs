using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCollision2 : MonoBehaviour
{
    // Boolean variable to track collision status
    bool isitColliding;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize isitColliding to false at the start
        isitColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If not colliding, move the object to the right
        if (isitColliding == false)
        {
            transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
        }

        // If colliding, move the object to the left
        if (isitColliding == true)
        {
            transform.position += new Vector3(-3 * Time.deltaTime, 0, 0);
        }
    }

    // Called when a collision occurs with another object
    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has the tag "WallEast" or "Hit"
        if (other.gameObject.tag == "WallEast" || other.gameObject.tag == "Hit")
        {
            // Set isitColliding to true
            isitColliding = true;
            // Move the object to the same position (0, 0, 0)
            transform.position += new Vector3(0, 0, 0);
        }

        // Check if the colliding object has the tag "WallWest" or "Hit"
        if (other.gameObject.tag == "WallWest" || other.gameObject.tag == "Hit")
        {
            // Set isitColliding to false
            isitColliding = false;
            // Move the object to the same position (0, 0, 0)
            transform.position += new Vector3(0, 0, 0);
        }
    }
}
