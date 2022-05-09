using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public VariableJoystick joystick;

    public float moveLRSpeed = 5;

    public float leftBound = -4;
    public float rightBound = 4;
    public float horizontal;
    int speed = 10;
    float lastPosition;

    public float REFRESH_TIME = 0.1f;
    private Vector3 touchStartPos;
    float refreshDelta = 0.0f;
    [SerializeField]
    [Range(5, 20)]
    float smoothingTime = 10.0f; //decrease value to move faster
    private void Update()
    {

        

        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Input.mousePosition;
            refreshDelta = 0.0f;
        }
        if (Input.GetMouseButton(0))
        {

            refreshDelta += Time.deltaTime;
            Vector3 diff = (Input.mousePosition - touchStartPos);
            Vector3 finalPos = transform.localPosition + diff;

            if (refreshDelta >= REFRESH_TIME)
            {

                refreshDelta = 0.0f;
                touchStartPos = Input.mousePosition;
            }
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(0, finalPos.x, transform.localPosition.z), Time.deltaTime / smoothingTime);

        }
        if (Input.GetMouseButtonUp(0))
        {
            touchStartPos = Input.mousePosition;
            //transform.localPosition = new Vector3(0, 0, 0);
        }


        Vector3 currentPos = transform.localPosition;
        currentPos.y = Mathf.Clamp(transform.localPosition.y, leftBound, rightBound);
        transform.localPosition = currentPos;
        return;

        /*horizontal = joystick.Horizontal;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                case TouchPhase.Moved:

                    break;

            }
        }

        if (joystick.Horizontal >= .01f) // && joystick.Horizontal !=lastPosition)
        {
            //horizontal = moveLRSpeed;
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            lastPosition = joystick.Horizontal;
            *//* if (lastPosition > rightBound)
                 return;*//*

        }
        else if (joystick.Horizontal <= -.01f) // && joystick.Horizontal != lastPosition)
        {
            //horizontal = -moveLRSpeed;
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            lastPosition = joystick.Horizontal;
            //transform.Translate(-Vector3.right * Time.deltaTime * speed);
            *//*if (lastPosition > leftBound)
                return;*//*

        }
*/


        //transform.position += new Vector3(horizontal * moveLRSpeed * Time.deltaTime, 0, 0);
    }


}
