using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontaFoguete : MonoBehaviour
{
    private SpaceShipMovement shipMove;

    private void Start()
    {
        shipMove = GetComponentInParent<SpaceShipMovement>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bola"))
        {
            shipMove.HitTarget();
        }
    }
}
