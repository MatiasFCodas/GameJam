using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    public float explosionStrength = 100;
    public float radius = 10f;

    public Collider2D[] colliders;

    private void Start()
    {
        colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        foreach (Collider2D hit in colliders)
        {
            Rigidbody2D[] rbs = new Rigidbody2D[colliders.Length];
            for (int i = 0; i <colliders.Length; i++)
            {
                //rbs[i] = 
                if(colliders[i].GetComponent<Rigidbody2D>() != null)
                {
                    rbs[i].AddExplosionForce(explosionStrength, this.transform.position, radius);
                    i++;
                }
            }
        }
    }
}
