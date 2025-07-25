using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class GreenColourChanger : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float timePassed;

    bool activate = true;
    bool deactivate = false;

    // Start is called before the first frame update
    void Start()
    {
        activate = false;
        deactivate = false;
    }

    // Update is called once per frame
    void Update()
    {
        //the speed of the piston if activated
        if (activate)
        {
            timePassed += Time.deltaTime;
            if (timePassed >= 1)
            {
                timePassed = 1;
            }
        }



        //the speed of the piston retracting if deactivated
        if (deactivate)
        {
            timePassed -= Time.deltaTime;
            if (timePassed <= 0)
            {
                timePassed = 0;
            }
        }

        //If 'E' is pressed, the piston will go down. If its released, it will go back up.
        if (Input.GetKeyDown(KeyCode.E))
        {
            activate = true;
            deactivate = false;
        }
        
        if(timePassed >= 1)
        {
            activate = false;
            deactivate = true;
        }
        Vector3 output = Vector3.Lerp(startPosition, endPosition, timePassed);
        transform.position = output;
    }

}

