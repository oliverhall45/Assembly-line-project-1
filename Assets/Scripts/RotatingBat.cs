//Makes the bat rotate perpetually

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBat : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationSpeed = -200f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
