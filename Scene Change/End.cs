using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    //Load level 1 after colliding with an object with the tag "End"
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene("Ending");
        }
    }
}