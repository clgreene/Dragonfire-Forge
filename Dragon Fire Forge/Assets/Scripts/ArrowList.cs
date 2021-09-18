using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowList : MonoBehaviour
{

    public GameObject[] arrowList;
    public ListData arrowPositions;
    public int length;
    

    // Start is called before the first frame update
    void Start()
    {
        
        while (length < (arrowList.Length - 1))
        {
            arrowPositions.value[length] = arrowList[length].transform.position;
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
