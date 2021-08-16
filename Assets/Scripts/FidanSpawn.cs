using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidanSpawn : MonoBehaviour
{
    public static int fidanCount = 0;
    private Vector3 fidanSpawnPos = new Vector3(-1, -10, 0);

   

    // Update is called once per frame
    void Update()
    {
        if (fidanCount >= 1)
        {
            fidanCount = 0;
            FidanProduct();
        }



    }

    void FidanProduct()
    {
        Instantiate((GameObject)Resources.Load("Prefabs/Fidan", typeof(GameObject)), fidanSpawnPos, Quaternion.identity);
    }
}
