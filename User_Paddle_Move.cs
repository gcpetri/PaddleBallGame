using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_Paddle_Move : MonoBehaviour
{
    Vector3 targetPosition;
    public float speed = 100;
    private bool moving = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (moving)
            Move();
    }

    void SetTargetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            targetPosition = hit.point;
            targetPosition.z = 9.57f;
            targetPosition.y = 0.57f;
            moving = true;
        }

    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
