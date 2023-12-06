using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the F5 key is pressed
        if (Input.GetKeyDown(KeyCode.F5))
        {
            // Load the "Title" scene
            SceneManager.LoadScene("Title");
        }
    }
}

