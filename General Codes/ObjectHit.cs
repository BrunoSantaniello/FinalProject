using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Called when a collision occurs with another object
    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has the tag "Player"
        if (other.gameObject.tag == "Player")
        {
            // Change the color of the object's MeshRenderer to black
            GetComponent<MeshRenderer>().material.color = Color.black;

            // Change the tag of the object to "Hit"
            gameObject.tag = "Hit";
        }
    }
}
