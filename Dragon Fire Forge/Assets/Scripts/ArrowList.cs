using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrowList : MonoBehaviour
{

    public GameObject[] arrowList;
    public bool[] right;
    public ListData arrowPositions;
    public bool positionUpdate;

    public Vector3 position;
    public float distance;

    public BoolData rightButton;
    public BoolData leftButton;

    public BellowsGame bellowsGame;
    public int nextArrow;
    public bool initialize;

    public float tooFar = .65f;
    public float perfect;

    public int arrowScore;
    public WeaponStats weaponStats;
    

    // Start is called before the first frame update
    void Start()
    {
        arrowPositions.number = 0;
        arrowPositions.listSet = false;
        initialize = true;
        nextArrow = 0;
        weaponStats.smeltScore = 0;
        positionUpdate = false;

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //tracking position for each item in array
        while (arrowPositions.number < (arrowList.Length) && initialize == true)
        {
            arrowPositions.positionValue.Add(arrowList[arrowPositions.number].transform.position);
            arrowPositions.boolValue.Add(right[arrowPositions.number]);
            arrowPositions.number++;

            if (arrowPositions.number == (arrowList.Length))
            {

                arrowPositions.listSet = true;
                arrowPositions.number = 0;
                initialize = false;
            }

        }

        //all gameplay logic once game begins
        if (arrowPositions.listSet == true)
        {

            //!!!possibly make this a while loop whose condition resets at the end of update, not the while loop!!!
            while(positionUpdate != true)
            {
                arrowPositions.positionValue[arrowPositions.number] = arrowList[arrowPositions.number].transform.position;
                arrowPositions.number++;

                if (arrowPositions.number == arrowList.Length) positionUpdate = true;
            }
            

            //reset arrow counter to zero after reaching the end of the list
            if (arrowPositions.number == (arrowList.Length))
            {
                arrowPositions.number = 0;
            }

            //clear arrow if it's gone to far
            if (nextArrow < (arrowList.Length) && arrowList[nextArrow].transform.position.y < -tooFar)
            {
                arrowList[nextArrow].SetActive(false);
                nextArrow++;
                if (nextArrow == arrowList.Length)
                {
                    weaponStats.smeltScore = (Mathf.FloorToInt(weaponStats.smeltScore /arrowList.Length));
                    arrowPositions.listOver = true;

                }
            }

            //clear arrow when right button is hit, and calculate score
            if (rightButton.value == true) 
            {
                if (right[nextArrow] == true)
                {
                    position.y = arrowList[nextArrow].transform.position.y;
                    distance = Mathf.Abs(perfect - position.y);
                    if (distance <= .06) 
                    {
                        arrowScore = 100;

                    }

                    else if (distance <= .17) 
                    {
                        arrowScore = (Mathf.FloorToInt((.17f - distance) * 900));
                    }

                    else
                    {
                        arrowScore = 0;
                    }

                    weaponStats.smeltScore += arrowScore;



                    Debug.Log(distance);
                    Debug.Log(arrowScore);
                }


                arrowList[nextArrow].SetActive(false);
                nextArrow++;

                if (nextArrow == arrowList.Length)
                {
                    weaponStats.smeltScore = (Mathf.FloorToInt(weaponStats.smeltScore/arrowList.Length));
                    arrowPositions.listOver = true;
                }
                rightButton.value = false;
            };


            //clear arrow when left button is hit, and calculate score
            if (leftButton.value == true)
            {
                if (right[nextArrow] == false)
                {
                    position.y = arrowList[nextArrow].transform.position.y;
                    distance = Mathf.Abs(perfect - position.y);
                    if (distance <= .06)
                    {
                        arrowScore = 100;

                    }

                    else if (distance <= .17)
                    {
                        arrowScore = (Mathf.FloorToInt((.17f - distance) * 900));
                    }

                    else
                    {
                        arrowScore = 0;
                    }

                    weaponStats.smeltScore += arrowScore;

                    Debug.Log(distance);
                    Debug.Log(arrowScore);
                }


                arrowList[nextArrow].SetActive(false);
                nextArrow++;
                if (nextArrow == arrowList.Length)
                {
                    weaponStats.smeltScore = (Mathf.FloorToInt(weaponStats.smeltScore / arrowList.Length));
                    arrowPositions.listOver = true;

                }
                leftButton.value = false;
            }


            positionUpdate = false;
            //when game ends, we need to avg the score with the array length, set score in weaponStats, and list game as over.

        }

    }
}
