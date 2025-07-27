using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateNewMovingObject : MonoBehaviour
{
    public GameObject newMovingObject;
    public Transform startPointInstantiator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateMovingObject()
    {
        
        GameObject movingObject = Instantiate(newMovingObject, transform.position, Quaternion.identity);

            if (startPointInstantiator != null)
            {
                movingObject.transform.SetParent(startPointInstantiator, false);
            }
        }

       
    }

