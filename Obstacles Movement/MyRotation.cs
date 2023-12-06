using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRotation : MonoBehaviour
{
    // Serialized field to allow rotation speed adjustment in the Unity Editor
    [SerializeField]
    float mySpeed = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its y-axis based on the specified speed
        transform.Rotate(0, mySpeed * Time.deltaTime, 0);
    }
}
