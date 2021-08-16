using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiseCollector : FidanSpawn
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PickUpP1.isHoldingP1 == true && collision.CompareTag("PetSise"))
        {
            PickUpP1.isHoldingP1 = false;
            Destroy(collision.gameObject);
            fidanCount++;

        }
        if (PickUpP2.isHoldingP2 == true && collision.CompareTag("PetSise"))
        {
            PickUpP2.isHoldingP2 = false;
            Destroy(collision.gameObject);
            fidanCount++;
        }
    }
}
