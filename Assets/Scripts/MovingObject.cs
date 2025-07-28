using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingObject : MonoBehaviour
{
    public GameObject colourChangerGreen;
    public GameObject colourChangerBlue;
    public GameObject destroyerPiston;
    public GameObject endPointDestroyer;
    public GameObject lightObject;
    public float triggerDistance = 1f;
    public float speed;
    public Slider speedSlider;
    public float targetPositionMax = 8;
    public float targetPositionMin = 7;

    SpriteRenderer movingObjectRenderer;
    SpriteRenderer lightObjectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        movingObjectRenderer = gameObject.GetComponent<SpriteRenderer>();
        lightObjectRenderer = lightObject.GetComponent<SpriteRenderer>();
        speedSlider.value = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed * Time.deltaTime;

        transform.position = newPosition;

        //turns the object green when the colour changer green piston touches it
        float distanceGreen = Vector3.Distance(transform.position, colourChangerGreen.transform.position);
        if(distanceGreen < triggerDistance)
        {
            movingObjectRenderer.color = Color.green;
        }

        //turns the object blue when the colour changer blue piston touches it
        float distanceBlue = Vector3.Distance(transform.position, colourChangerBlue.transform.position);
        if (distanceBlue < triggerDistance)
        {
            movingObjectRenderer.color = Color.blue;
        }

        //Destroys the object when the destroy piston touches it
        float distanceDestroy = Vector3.Distance(transform.position, destroyerPiston.transform.position);
        if (distanceDestroy < triggerDistance)
        {
            Destroy(gameObject);
        }

        //Destroys the object when it reaches the end of its path
        float distanceDestroyEnd = Vector3.Distance(transform.position, endPointDestroyer.transform.position);
        if (distanceDestroyEnd < triggerDistance)
        {
            Destroy(gameObject);
            
        }

        if (movingObjectRenderer.color == Color.green && transform.position.x <= targetPositionMax && transform.position.x >= targetPositionMin)
        {
            lightObjectRenderer.material.color = Color.green;
        }

        if (movingObjectRenderer.color == Color.blue && transform.position.x <= targetPositionMax && transform.position.x >= targetPositionMin)
        {
            lightObjectRenderer.material.color = Color.yellow;
        }

        if(movingObjectRenderer.color != Color.blue && movingObjectRenderer.color != Color.green && transform.position.x <= targetPositionMax && transform.position.x >= targetPositionMin)
        {
            lightObjectRenderer.material.color = Color.red;
        }


    }
    public void SpeedSlider()
    {
        speed = speedSlider.value;
    }
}
