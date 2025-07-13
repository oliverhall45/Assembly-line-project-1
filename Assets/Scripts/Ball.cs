using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float pointA;
    public float pointB;
    public float speed = 0.02f;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed;

        transform.position = newPosition;

        bool buttonHit = transform.position.x > pointA;

        if (buttonHit)
        {
            speed = speed - 0.04f;
        }

        bool batHit = transform.position.x < pointB;

        if (batHit)
        {
            speed = speed + 0.04f;
        }
    }
}
