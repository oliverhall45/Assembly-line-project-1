using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingRectangle : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationSpeed = 50f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
