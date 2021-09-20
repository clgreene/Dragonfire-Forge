using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BellowsGame : MonoBehaviour
{

    public GameObject[] arrowGames;
    public GameObject currentGame;
    public int randomInt = 1;
    public bool foundNextArrow;
    public int nextArrow;
    public BoolData start;
    public BoolData playing;
    public int arrow = 0;
    public int weaponMat;
    public ListData arrowPositions;

    // Start is called before the first frame update
    void Start()
    {
        nextArrow = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (start.value == true)
        {
            StartCoroutine(initializeGame());

            

            
            //if mousebuttondown then access arrow position, play arrow animation based on position, and hide arrow until off screen (unless game object resets itself when reused, then just hide arrow)
            //if arrow position is past too far position, play missed animation at position, and hide arrow
            //increase arrow number by one
            //if arrow number is larger than list, playing is false.


        }
        if (playing.value == true)
        {
            currentGame.transform.Translate(0, -1 * Time.deltaTime, 0);
            
        }

        //reset the next arrow for the buttons when arrow has travelled to far
        if (playing.value == true)
        {
            //ERROR HERE!!!! Reading these values while arrowPositions count is empty of values, then doesn't come back to it.
            if (arrowPositions.value[nextArrow].y < -.65)
            {
                nextArrow++;
                Debug.Log(nextArrow);

                if (nextArrow > (arrowPositions.value.Count - 1))
                {
                    playing.value = false;
                }

            }
            
            


        }

    }

    public IEnumerator initializeGame()
    {
        start.value = false;
        arrowPositions.value.Clear();
        yield return new WaitForSeconds(0f);
        playing.value = true;
        randomInt = Random.Range(1, arrowGames.Length);
        currentGame = Instantiate(arrowGames[randomInt - 1]);
        StartCoroutine(countDown());
        weaponMat = 1;
        arrow = 0;

    }


    public IEnumerator countDown()
    {

        yield return new WaitForSeconds(0f);
        //play start animation



    }

    public IEnumerator rightButton()
    {
        yield return new WaitForSeconds(0f);
        nextArrow++;


        //checkArrowDirection
        //CompareArrowPosition to Best Position
        //run animation / hide arrow
        //calculate score and add score
        //move to next arrow

    }

    public IEnumerator leftButton()
    {
        yield return new WaitForSeconds(0f);

    }


}
