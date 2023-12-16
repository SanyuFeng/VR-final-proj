using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [Range(0.1f, 1f)]
    public float scaleSpeed = 1f;

    void Update()
    {
        // Check if there are any touches
        if (Input.touchCount > 0)
        {
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // Check if the touch is on the right side of the screen
            if (touch.position.x > Screen.width / 2)
            {
                // Scale up when touching the right side
                transform.localScale += new Vector3(0.1f * scaleSpeed, 0.1f * scaleSpeed, 0);
            }
            else
            {
                // Scale down when touching the left side
                transform.localScale -= new Vector3(0.1f * scaleSpeed, 0.1f * scaleSpeed, 0);
            }
        }
    }
}
