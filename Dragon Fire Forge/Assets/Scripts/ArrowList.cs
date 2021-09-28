using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrowList : MonoBehaviour
{

    public GameObject[] arrowList;
    public bool[] right;
    public ListData arrowPositions;

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
    public IntData score;
    

    // Start is called before the first frame update
    void Start()
    {
        arrowPositions.number = 0;
        arrowPositions.listSet = false;
        initialize = true;
        nextArrow = 0;
        score.value = 0;

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //tracking position for each item in array
        while (arrowPositions.number < (arrowList.Length - 1) && initialize == true)
        {
            arrowPositions.positionValue.Add(arrowList[arrowPositions.number].transform.position);
            arrowPositions.boolValue.Add(right[arrowPositions.number]);
            arrowPositions.number++;

            if (arrowPositions.number == (arrowList.Length - 1))
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
            arrowPositions.positionValue[arrowPositions.number] = arrowList[arrowPositions.number].transform.position;
            arrowPositions.number++;

            //reset arrow counter to zero after reaching the end of the list
            if (arrowPositions.number == (arrowList.Length - 1))
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
                    score.value = (Mathf.FloorToInt(score.value / arrowList.Length));
                    arrowPositions.listOver = true;

                }
            }

            //clear arrow when right button is hit, and calculate score
            if (rightButton.value == true) 
            {
                if (right[nextArrow] == true)
                {
                    position = arrowPositions.positionValue[nextArrow];
                    distance = Mathf.Abs(perfect - position.y);
                    if (distance <= .01) 
                    {
                        arrowScore = 100;

                    }

                    else if (distance <= .17) 
                    {
                        arrowScore = (Mathf.FloorToInt(distance * 588) + 5);
                    }

                    else
                    {
                        arrowScore = 0;
                    }

                    score.value += arrowScore;
                    

                    Debug.Log(distance);
                }

                

                arrowList[nextArrow].SetActive(false);
                nextArrow++;
                if (nextArrow == arrowList.Length)
                {
                    score.value = (Mathf.FloorToInt(score.value/arrowList.Length));
                    arrowPositions.listOver = true;
                }
                rightButton.value = false;
            };


            //clear arrow when left button is hit, and calculate score
            if (leftButton.value == true)
            {
                if (right[nextArrow] == false)
                {
                    position = arrowPositions.positionValue[nextArrow];
                    distance = Mathf.Abs(perfect - position.y);
                    if (distance <= .01)
                    {
                        arrowScore = 100;

                    }

                    else if (distance <= .17)
                    {
                        arrowScore = (Mathf.FloorToInt(distance * 588) + 5);
                    }

                    else
                    {
                        arrowScore = 0;
                    }

                    score.value += arrowScore;


                    Debug.Log(distance);
                }


                arrowList[nextArrow].SetActive(false);
                nextArrow++;
                if (nextArrow == arrowList.Length)
                {
                    score.value = (Mathf.FloorToInt(score.value / arrowList.Length));
                    arrowPositions.listOver = true;

                }
                leftButton.value = false;
            }


            //when game ends, we need to avg the score with the array length, set score in weaponStats, and list game as over.

        }

    }
}
