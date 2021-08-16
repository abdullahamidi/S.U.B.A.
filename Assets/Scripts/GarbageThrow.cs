using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageThrow : MonoBehaviour
{
    [SerializeField] private float throwSpeed;
    Vector2 target;
    bool isArrived = false;
    private void Start()
    {
        target = ArrayController.instance.PosYolla();
        target.y -= 1;
    }

    void Update()
    {
        if (isArrived == false)
        {
            var step = throwSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target, step);
            if ((Vector2)transform.position == target)
            {
                isArrived = true;
            }
        }
        else
        {
            this.gameObject.GetComponent<Collider2D>().enabled = true;
            this.gameObject.GetComponent<Collider2D>().isTrigger = true;
        }
    }
}
