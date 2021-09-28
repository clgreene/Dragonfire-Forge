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
    public BoolData leftButton;
    public BoolData rightButton;
    public int arrow = 0;
    public IntData weaponMat;
    public ListData arrowPositions;

    public CurrentContract currentContract;

    // Start is called before the first frame update
    void Start()
    {
        //resetting arrow transforms at new game.
        nextArrow = 0;
        arrowPositions.listOver = false;
        arrowPositions.listSet = false;
        arrowPositions.number = 0;

        //setting current contract expectations
        


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
        
        if (arrowPositions.listOver == false && arrowPositions.listSet == true)
        {
            currentGame.transform.Translate(0, -1 * Time.deltaTime, 0);
            
        }
        
        //reset the next arrow for the buttons when arrow has travelled to far
 
    }

    public IEnumerator initializeGame()
    {
        start.value = false;
        arrowPositions.positionValue.Clear();
        randomInt = Random.Range(1, arrowGames.Length);
        currentGame = Instantiate(arrowGames[randomInt - 1]);
        playing.value = true;
        StartCoroutine(countDown());
        arrow = 0;
        yield return new WaitForSeconds(0f);

    }


    public IEnumerator countDown()
    {

        yield return new WaitForSeconds(0f);
        //play start animation



    }

    public void rightButtonPressed()
    {
        rightButton.value = true;
    }

    public void leftButtonPressed()
    {
        leftButton.value = true;
    }
}
