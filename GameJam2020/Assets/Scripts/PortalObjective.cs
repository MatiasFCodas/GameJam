using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalObjective : MonoBehaviour
{
    public FloatVariable finishedObjectives;

    private void Start()
    {
        finishedObjectives = Resources.Load<FloatVariable>("FinishedObjectives");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bola"))
        {
            finishedObjectives.Value++;
            Destroy(col.gameObject);
        }
    }
}
