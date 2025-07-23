using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public GameObject colourChangerGreen;
    public GameObject colourChangerBlue;
    public float triggerDistance = 1f;
    public float speed;

    SpriteRenderer movingObjectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        movingObjectRenderer = gameObject.GetComponent<SpriteRenderer>();
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
    }
}
