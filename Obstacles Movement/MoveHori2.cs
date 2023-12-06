using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHori2 : MonoBehaviour
{
    float moveSpeedOne;
    float moveSpeedTwo;
    bool isitSo;

    // Start is called before the first frame update
    void Start()
    {
        // Set initial values for movement speeds and state
        moveSpeedOne = 7f;
        moveSpeedTwo = 7f;
        isitSo = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object along the x-axis using moveSpeedOne
        transform.Translate(moveSpeedOne * Time.deltaTime, 0, 0);

        // Check if the object's x-position is greater than or equal to 70
        if (transform.position.x >= 70f)
        {
            // Update movement parameters when reaching or exceeding a certain position
            moveSpeedOne = 0f;
            isitSo = false;
            moveSpeedTwo = -7f;
        }

        // Check if the object's x-position is less than or equal to 55
        if (transform.position.x <= 55f)
        {
            // Update movement parameters when reaching or exceeding a certain position
            moveSpeedTwo = 0f;
            isitSo = true;
            moveSpeedOne = 7f;
        }

        // If isitSo is true, move the object along the x-axis using moveSpeedOne
        if (isitSo == true)
        {
            transform.Translate(moveSpeedOne * Time.deltaTime, 0, 0);
        }

        // If isitSo is false, move the object along the x-axis using moveSpeedTwo
        if (isitSo == false)
        {
            transform.Translate(moveSpeedTwo * Time.deltaTime, 0, 0);
        }
    }
}
