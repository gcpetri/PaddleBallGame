using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU_Paddle_Behavior : MonoBehaviour
{
    public Transform followBall;
    public float mSpeed;
    Vector3 followDirection;
    const float EPSILON = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followDirection = (followBall.position - transform.position).normalized;
        followDirection.z = 0;
        followDirection.y = 0;
        if ((transform.position - followBall.position).magnitude > EPSILON)
        {
            this.transform.Translate(mSpeed * Time.deltaTime * followDirection);
        }
    }
}
