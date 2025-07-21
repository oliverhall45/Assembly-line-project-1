using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class Pistons : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed;

    bool activate = true;
    bool deactivate = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activate)
        {
            speed += Time.deltaTime;
            if(speed >= 1)
            {
                speed = 1;
            }
        }

        if (deactivate)
        {
            speed -= Time.deltaTime;
            if (speed <= 0)
            {
                speed = 0;
            }
        }


        if (Input.GetKey(KeyCode.E))
        {
            activate = true;
            deactivate = false;
        }
        else
        {
            activate = false;
            deactivate = true;
        }
        Vector3 output = Vector3.Lerp(startPosition, endPosition, speed);
        transform.position = output;
    }
}

