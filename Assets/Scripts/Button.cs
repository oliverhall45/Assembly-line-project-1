using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject ball;
    public float triggerDistance = 1f;
    public Color activateColor = Color.red;
    public Color defaultColor = Color.green;


    SpriteRenderer buttonRenderer;

   

    // Start is called before the first frame update
    void Start()
    {
        buttonRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball == null)
        {
            GameObject ballObj = GameObject.Find("Ball");
            if (ballObj != null)
            {
                ball = ballObj;
            }
            else
            {
                return;
            }
        }
        //If the ball is near the button, it will activate and turn red. Otherwise, it will stay green when the ball leaves.
        float distance = Vector3.Distance(transform.position, ball.transform.position);
        if(distance <= triggerDistance)
        {
            buttonRenderer.color = activateColor;
        }
        else
        {
            buttonRenderer.color = defaultColor;
        }
    }
}
