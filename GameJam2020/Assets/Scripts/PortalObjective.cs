using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalObjective : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bola"))
        {
            Destroy(col.gameObject);
        }
    }
}
