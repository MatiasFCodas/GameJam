using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float launchForce = 10f;
    public float thrustForce = 20f;
    public float torqueForce;

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
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Propulsor");
                rb.AddForce(transform.up * thrustForce);
                launched = true;
            }
        }
    }

    void HitTarget()
    {
        torqueForce = Random.Range(5, 12);
        Debug.Log("Hit");
        rb.AddTorque(torqueForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bola"))
        {
            HitTarget();
        }
    }
}
