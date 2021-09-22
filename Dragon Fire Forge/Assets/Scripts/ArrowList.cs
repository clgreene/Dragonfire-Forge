using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowList : MonoBehaviour
{

    public GameObject[] arrowList;
    public ListData arrowPositions;
    
    public BellowsGame bellowsGame;
    public int nextArrow;
    public bool initialize;
    

    // Start is called before the first frame update
    void Start()
    {
        arrowPositions.number = 0;
        initialize = true;
        nextArrow = 0;

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        //resetting position tracker to first item in list
        

        //tracking position for each item in array
        while (arrowPositions.number < (arrowList.Length - 1) && initialize == true)
        {
            arrowPositions.value.Add(arrowList[arrowPositions.number].transform.position);
            arrowPositions.number++;

            if (arrowPositions.number == (arrowList.Length - 1))
            {

                arrowPositions.listSet = true;
                arrowPositions.number = 0;
                initialize = false;
            }

        }

        if (arrowPositions.listSet == true)
        {
            arrowPositions.value[arrowPositions.number] = arrowList[arrowPositions.number].transform.position;
            arrowPositions.number++;

            if (arrowPositions.number == (arrowList.Length - 1))
            {
                arrowPositions.number = 0;
            }

            if (nextArrow < (arrowList.Length) && arrowList[nextArrow].transform.position.y < -.65)
            {
                arrowList[nextArrow].SetActive(false);
                nextArrow++;
                if (nextArrow == arrowList.Length)
                {
                    arrowPositions.listOver = true;
                    arrowPositions.listSet = false;
                }
            }

        }

    }
}
