using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behavior : MonoBehaviour
{
    public float speed;
    public Rigidbody ball;
    public float acceleration = 0.1f;
    public float score = 0.0f;
    private Vector3 rotation;

    void Start()
    {
        rotation.x = 0;
        rotation.z = 0;
        rotation.y = Random.Range(-20f, 20f);
        this.transform.Rotate(rotation);
        ball.velocity = -transform.forward * speed;
    }

    void Update()
    {
        if (ball.velocity.magnitude < 40f)
            ball.velocity += ball.velocity * Time.deltaTime * acceleration;
    }
 
    void OnTriggerEnter(Collider other)
    {
        score = score + 1.0f;
    }
}
