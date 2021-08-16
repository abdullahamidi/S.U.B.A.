using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawn : MonoBehaviour
{
    [SerializeField] private float garbageStartTime;
    [SerializeField] private float garbagePeriodTime;
    [SerializeField] private Vector2 center;
    [SerializeField] private Vector2 size;
    private GameObject canvas;

    void Start()
    {
        InvokeRepeating("Generate", garbageStartTime, garbagePeriodTime);
        canvas = GameObject.Find("Canvas");
    }

    private void Update()
    {
        if (Tree.isLastTree)
        {
            Time.timeScale = 0;
            canvas.transform.Find("LosePanel").gameObject.SetActive(true);
            Timer.timerIsRunning = false;
            Tree.isLastTree = false;
        }
        if (Time.timeScale == 0)
        {
            CancelInvoke("Generate");
        }
    }

    void Generate()
    {
        int pickGarbage = Random.Range(1, 3);

        Vector2 randomPos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));
        switch (pickGarbage)
        {
            case 1:
                Instantiate((GameObject)Resources.Load("Prefabs/Sigara", typeof(GameObject)), randomPos, Quaternion.identity);
                break;
            case 2:
                Instantiate((GameObject)Resources.Load("Prefabs/PetSise", typeof(GameObject)), randomPos, Quaternion.identity);
                break;
            /*case 3:
                Instantiate((GameObject)Resources.Load("Prefabs/CopPoseti", typeof(GameObject)), randomPos, Quaternion.identity);
                break;*/
            default:
                break;
        }
    }
}
