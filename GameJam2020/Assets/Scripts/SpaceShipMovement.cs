using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float launchForce = 10f;
    public float thrustForce = 20f;
    public float torqueForce;

    public float rotationSpeed = 60f;

    public bool launched;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(launched == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * launchForce, ForceMode2D.Impulse);
                launched = true;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
            }
        }

        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(transform.up * thrustForce);
                launched = true;
            }

        }
    }

    public void HitTarget()
    {
        torqueForce = Random.Range(-0.5f, 0.5f);
        rb.AddTorque(torqueForce, ForceMode2D.Impulse);
    }

}
