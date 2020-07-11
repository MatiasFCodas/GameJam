using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    public float explosionStrength = 100;
    public float radius = 10f;

    public Collider2D[] colliders;
    public Rigidbody2D[] rbs;

    private void Start()
    {
        colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        foreach (Collider2D hit in colliders)
        {
            for(int i = 0; i <colliders.Length; i++)
            {
                if(colliders[i].GetComponent<Rigidbody2D>() != null)
                {
                    rbs[i] = colliders[i].GetComponent<Rigidbody2D>();
                    rbs[i].AddExplosionForce(explosionStrength, this.transform.position, radius);
                    i++;
                }
            }
        }
    }
}
