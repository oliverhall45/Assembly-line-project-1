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
    public float triggerDistance = 1f;
    public float speed;
    public Slider speedSlider;

    SpriteRenderer movingObjectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        movingObjectRenderer = gameObject.GetComponent<SpriteRenderer>();
        speedSlider.value = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed * Time.deltaTime;

        transform.position = newPosition;

        float distanceGreen = Vector3.Distance(transform.position, colourChangerGreen.transform.position);
        if(distanceGreen < triggerDistance)
        {
            movingObjectRenderer.color = Color.green;
        }

        float distanceBlue = Vector3.Distance(transform.position, colourChangerBlue.transform.position);
        if (distanceBlue < triggerDistance)
        {
            movingObjectRenderer.color = Color.blue;
        }

        float distanceDestroy = Vector3.Distance(transform.position, destroyerPiston.transform.position);
        if (distanceDestroy < triggerDistance)
        {
            Destroy(gameObject);
        }

        float distanceDestroyEnd = Vector3.Distance(transform.position, endPointDestroyer.transform.position);
        if (distanceDestroyEnd < triggerDistance)
        {
            Destroy(gameObject);
        }

    }
    public void SpeedSlider()
    {
        speed = speedSlider.value;
    }
}
