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
        length = 0;

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (length == (arrowList.Length - 1))
        {
            arrowPositions.value.Clear();
            length = 0;
        }

        while (length < (arrowList.Length - 1))
        {
            arrowPositions.value.Add(arrowList[length].transform.position);
            length++;

        }
    }
}
