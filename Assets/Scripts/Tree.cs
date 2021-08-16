using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tree : MonoBehaviour
{
    private int timeLeft = 5;
    bool isCalled = false;
    bool onFire = false;
    public static bool isLastTree = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sigara"))
        {
            timeLeft -= 3;
        }
        if(collision.CompareTag("PetSise"))
        {
            timeLeft -= 2;
        }
    }
    void Update()
    {
        if (onFire)
        {
            SoundManager.PlaySound("burningwood");
            //Debug.Log("yanıyo");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(timeLeft);
        if (collision.CompareTag("Sigara") || collision.CompareTag("PetSise") && isCalled == false)
        {
            transform.Find("Fireicli").gameObject.SetActive(true);
            onFire = true;
            InvokeRepeating("Damage", 1.0f, 1.0f);
            isCalled = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (timeLeft >= 0 && collision.CompareTag("Sigara") || collision.CompareTag("PetSise"))
        {
            transform.Find("Fireicli").gameObject.SetActive(false);
            onFire = false;
            CancelInvoke("Damage");
            timeLeft = 4;
            isCalled = false;
        }


    }

    void Damage()
    {
        if (timeLeft >= 0)
        {
            //Debug.Log(timeLeft);
            timeLeft -= 1;
        }
        
        else
        {
           // Debug.Log("BITTI" + Time.time);
            Destroy(this.gameObject);
            transform.Find("Fireicli").gameObject.SetActive(false);
            onFire = false;
            Timer.agacCount--;
            if (ArrayController.instance.AvaliablePos.Count == 0)
            {
                isLastTree = true;
            }
            //Animasyon


        }
    }
}
