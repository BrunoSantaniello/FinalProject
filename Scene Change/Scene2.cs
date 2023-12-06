using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    //Load level 2 after colliding with an object with the tag "Scene2"
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Scene2"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}