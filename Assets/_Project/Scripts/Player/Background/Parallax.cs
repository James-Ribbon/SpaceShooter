using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    /**public float multiplier;

    public bool horizontalOnly;
    public bool CalcHoriPos;
    public bool CalcVertPos;
    public bool isInfinite;

    private Camera mainCamera;

    private Vector3 startPos;
    private Vector3 startCamPos;
    private float length;

    private void Start()
    {
        mainCamera = Camera.main;
        startPos = transform.position;
        startCamPos = mainCamera.transform.position;

        if(isInfinite)
            length = GetComponent<SpriteRenderer>().bounds.size.y;

        CalculateStartPosition();
    }

    private void CalculateStartPosition()
    {
        float distX = (mainCamera.transform.position.x - transform.position.x) * multiplier;
        float distY = (mainCamera.transform.position.y - transform.position.y) * multiplier;

        Vector3 tmp = new Vector3(startPos.x, startPos.y);

        if(CalcHoriPos)
            tmp.x = transform.position.x + distX;

        if (CalcVertPos)
            tmp.y = transform.position.y + distY;

        startPos = tmp;
    }

    private void FixedUpdate()
    {
        //transform.position = new Vector3(transform.position.x, startPos.y + (mainCamera.transform.position.y * multiplier), transform.position.z);

        Vector3 position = startPos;

        if (horizontalOnly)
        {
            position.x += multiplier * (mainCamera.transform.position.x - startCamPos.x);
        }
        else
        {
            position += multiplier * (mainCamera.transform.position - startCamPos);
        }

        transform.position = position;

        if (isInfinite)
        {
            float temp = (mainCamera.transform.position.y - startCamPos.y) * (1 - multiplier);
            startPos.y += temp;
            startCamPos = mainCamera.transform.position;
            if (Mathf.Abs(mainCamera.transform.position.y - transform.position.y) >= length)
            {
                startPos.y += length * (mainCamera.transform.position.y > transform.position.y ? 1 : -1);
            }

            /*
            float temp = mainCamera.transform.position.x * (1 - multiplier);

            if(temp > startPos.x + length)            
                startPos.x += length;
            else if(temp < startPos.x - length)  
                startPos.x -= length;

             
        }*/

    private float length;
    private float startPos;

    public float scrollSpeed = 2f;
    public float parallaxEffect;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        startPos = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    /*private void FixedUpdate()
    {
        float temp = (mainCamera.transform.position.y * (1 - parallaxEffect));

        float distance = (mainCamera.transform.position.y * parallaxEffect);

        transform.position = new Vector3(transform.position.x, startpos + distance, transform.position.z);

        if(temp > startpos + length)
            startpos += length;
        else if (temp < startpos - length)
            startpos -= length;
    }*/

    private void FixedUpdate()
    {
        transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime * parallaxEffect);

        // Check if the background has moved off-screen
        if (transform.position.y < startPos - length)
        {
            // Reset the background to the top
            transform.position = new Vector3(transform.position.x, startPos, transform.position.z);
        }
    }
}
