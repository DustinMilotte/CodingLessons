using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBasketballPlayer : MonoBehaviour
{
    public GameObject ball;
    public Transform ballSpawnPoint;
    public float strength;
    public float shotAngle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ShootBall();
        }
    }

    private void ShootBall()
    {
        // Spawn a ball
        GameObject ballToThrow = Instantiate(ball, ballSpawnPoint.position, Quaternion.identity);

        // get a reference to the balls rigidbody
        Rigidbody ballRigidbody = ballToThrow.GetComponent<Rigidbody>();
        // calculate vector to throw the ball, should be forward and up from the player position
        Vector3 throwDirection = new Vector3(transform.forward.x, transform.forward.y + shotAngle, transform.forward.z);
        // add a force to the ball
        ballRigidbody.AddRelativeForce(throwDirection * strength);
    }
}
