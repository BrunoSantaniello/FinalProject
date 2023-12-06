using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Variable to store the number of hits
    int hits = 0;

    // Called when a collision occurs with another object
    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object does not have the tag "Hit"
        if (other.gameObject.tag != "Hit")
        {
            // Increment the hits counter
            hits++;

            // Display the updated number of hits in the console
            Debug.Log("Your fails: " + hits);
        }
    }
}
