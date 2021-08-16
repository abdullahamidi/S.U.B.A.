using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PickUpP2 : MonoBehaviour
{
    Vector2 rayDirection;
    RaycastHit2D hit;
    BoxCollider2D boxCollider;
    [SerializeField] LayerMask garbageLayerMask;
    static public bool isHoldingP2 = false;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        if (!isHoldingP2)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                rayDirection = (Vector3.right);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                rayDirection = (Vector3.left);
            }

            if (canCollect() && Input.GetKeyDown(KeyCode.Space))
            {
                hit.transform.parent = this.transform;
                hit.transform.position = transform.position;
                isHoldingP2 = true;
            }

        }
    }

    bool canCollect()
    {
        hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, rayDirection, 0.5f, garbageLayerMask);
        return hit.collider != null;
    }
}
