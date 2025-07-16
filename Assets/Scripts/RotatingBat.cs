//Makes the bat rotate perpetually

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBat : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 rotationAxis = Vector3.up; // Change to Vector3.right or Vector3.forward if needed
    public float rotationSpeed = 360f; // degrees per second
    private bool isRotating = false;

    void Start()
    {
        StartCoroutine(RotateForDuration(1f));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRotating)
        {
            StartCoroutine(RotateForDuration(1f)); // Rotate for 1 second
        }
    }

    System.Collections.IEnumerator RotateForDuration(float duration)
    {
        isRotating = true;

        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float step = rotationSpeed * Time.deltaTime;
            transform.Rotate(rotationAxis, step);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isRotating = false;
    }
}
