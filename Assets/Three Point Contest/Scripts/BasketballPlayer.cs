using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketballPlayer : MonoBehaviour
{
    public GameObject ball;
    public Transform ballSpawnPoint;
    public float shotStrength;
    public float shotHardcode;
    public float strengthIncrement;
    public float maxStrength;
    public float minStrength;
    public float shotAngle;
    public float rotateSpeed;
    public Slider slider;

    public bool poweringUp;

    private void Start()
    {
        shotStrength = minStrength;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && shotStrength > minStrength)
        {
            ShootBall();
        }
        else
        {
            CalculateShotStrength();
        }

        Aim();
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
        ballRigidbody.AddRelativeForce(throwDirection * shotStrength);
        
        // reset shot strength
        shotStrength = minStrength;
        poweringUp = true;
        UpdateSlider();
    }

    private void Aim()
    {
        // if A is pressed 
        if (Input.GetKey(KeyCode.A))
        {
            // rotate left
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        // else if D is pressed 
        else if (Input.GetKey(KeyCode.D))
        {
            // rotate right
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        
    }

    private void CalculateShotStrength()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (poweringUp)
            {
                if (shotStrength < maxStrength)
                {
                    shotStrength += strengthIncrement*Time.deltaTime;
                }
                else
                {
                    poweringUp = false;
                }
            }

            if (!poweringUp)
            {
                if (shotStrength < minStrength)
                {
                    poweringUp = true;
                }
                else
                {
                    shotStrength -= strengthIncrement*Time.deltaTime;
                }
            }
            UpdateSlider();
        }
    }

    private void UpdateSlider()
    {
        float range = maxStrength - minStrength;
        float currentSpotInSpan = shotStrength - minStrength;
        float percentageFilled = currentSpotInSpan / range;
        slider.value = percentageFilled;
    }
}