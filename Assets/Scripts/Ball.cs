//Makes the ball bounce back and forth from the bat to the button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float pointA;
    public float pointB;
    public float speed = 0.04f;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        //starting point of the ball
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed;

        transform.position = newPosition;

        //Variable that defines the location of the button and where the ball will change directions
        bool buttonHit = transform.position.x > pointA;

        if (buttonHit)
        {
            speed = speed - 0.04f;
        }

        //Variable that defines the location the ball is to stop and wait to be hit by the bat
        bool batSwing = Input.GetMouseButtonDown(0);
        bool batHit = transform.position.x <= pointB;

        if (batSwing)
        {
            speed = 0.04f;
        }
        else if (batHit)
        {
            speed = 0f;
        }
        
    }
}

