using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowList : MonoBehaviour
{

    public GameObject[] arrowList;
    public ListData arrowPositions;
    public int length;
    public BellowsGame bellowsGame;
    public int nextArrow;
    

    // Start is called before the first frame update
    void Start()
    {
        length = 0;

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        //resetting position tracker to first item in list
        if (length == (arrowList.Length - 1))
        {
            arrowPositions.value.Clear();
            length = 0;
        }

        //tracking position for each item in array
        while (length < (arrowList.Length - 1))
        {
            arrowPositions.value.Add(arrowList[length].transform.position);
            length++;

        }

        if (arrowList[nextArrow].transform.position.y < -.6 && nextArrow <= (arrowList.Length - 1))
        {
            arrowList[nextArrow].SetActive(false);
            nextArrow++;
        }
    }
}
