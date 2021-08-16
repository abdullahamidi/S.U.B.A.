using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fidan : MonoBehaviour
{
    GameObject dummy;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Toprak") && (collision.transform.Find("Tree") == false))
        {
            Debug.Log(PickUpP1.isHoldingP1);
            if (PickUpP1.isHoldingP1 == true && Input.GetKeyDown(KeyCode.Keypad0))
            {
                transform.parent = null;
                transform.position = collision.transform.position;
                PickUpP1.isHoldingP1 = false;
                dummy = Instantiate((GameObject)Resources.Load("Prefabs/Tree", typeof(GameObject)), transform.position, Quaternion.identity);
                dummy.transform.parent = collision.transform;
                ArrayController.instance.GetDeathPosition(transform.position);
                SoundManager.PlaySound("planting");
                Destroy(transform.gameObject);
            }
            if (PickUpP2.isHoldingP2 == true && Input.GetKeyDown(KeyCode.Space))
            {
                transform.parent = null;
                transform.position = collision.transform.position;
                PickUpP2.isHoldingP2 = false;
                dummy = Instantiate((GameObject)Resources.Load("Prefabs/Tree", typeof(GameObject)), transform.position, Quaternion.identity);
                ArrayController.instance.GetDeathPosition(transform.position);
                Timer.agacCount++;
                dummy.transform.parent = collision.transform;
                SoundManager.PlaySound("planting");
                Destroy(transform.gameObject);
            }
        }
    }

}
