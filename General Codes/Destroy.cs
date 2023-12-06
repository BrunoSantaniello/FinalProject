using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the "L" key is pressed
        if (Input.GetKey(KeyCode.L))
        {
            // Destroy the object this script is attached to
            Destroy(gameObject);
        }
    }
}
