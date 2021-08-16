using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigaraCollecter : FidanSpawn
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PickUpP1.isHoldingP1 == true && collision.CompareTag("Sigara"))
        {
            PickUpP1.isHoldingP1 = false;
            Destroy(collision.gameObject);
            fidanCount++;

        }
        if (PickUpP2.isHoldingP2 == true && collision.CompareTag("Sigara"))
        {
            PickUpP2.isHoldingP2 = false;
            Destroy(collision.gameObject);
            fidanCount++;
        }
    }
}
