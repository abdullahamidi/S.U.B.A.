using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayController : MonoBehaviour
{
    public static ArrayController instance;
    private GameObject AgacYerleri;
    private int posArrayIndex;
    protected Vector2 targetPos;
    private List<int> _availablePos = new List<int>();
    public List<int> AvaliablePos { get { return _availablePos; }}
    public List<GameObject> posArray = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        

        AgacYerleri = GameObject.Find("AgacYerleri");
        int i = 0;
        foreach (Transform child in AgacYerleri.transform)
        {
            posArray.Add(child.gameObject);
            _availablePos.Add(i);
            i++;
        }
        
        
    }

    public Vector2 PosYolla()
    {
        posArrayIndex = Random.Range(0, _availablePos.Count);

        targetPos = posArray[_availablePos[posArrayIndex]].transform.position;
        _availablePos.RemoveAt(posArrayIndex);
        return targetPos;
        
        //posArray.RemoveAt(posArrayIndex);
    }
    public void GetDeathPosition(Vector3 location)
    {
        for (int posArrayIndex = 0; posArrayIndex < posArray.Count; posArrayIndex++)
        {
            if(posArray[posArrayIndex].transform.position == location)
            {
                _availablePos.Add(posArrayIndex);
                break;
            }
        }
    }

    
}
