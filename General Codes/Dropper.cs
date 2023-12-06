using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer; // Declare a variable to hold the MeshRenderer component
    Rigidbody rigidBody; // Declare a variable to hold the Rigidbody component

    [SerializeField] float timetoWait = 5f; // Serialized field to allow adjustment in the Unity Inspector

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>(); // Get the MeshRenderer component attached to this GameObject
        rigidBody = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to this GameObject

        renderer.enabled = false; // Initially, disable the MeshRenderer
        rigidBody.useGravity = false; // Initially, disable gravity for the Rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the elapsed time is greater than the specified time to wait
        if (Time.time > timetoWait)
        {
            renderer.enabled = true; // Enable the MeshRenderer
            rigidBody.useGravity = true; // Enable gravity for the Rigidbody
        }
    }
}
