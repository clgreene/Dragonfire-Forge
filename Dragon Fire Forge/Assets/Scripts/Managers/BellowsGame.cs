using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BellowsGame : MonoBehaviour
{


    public GameObject[] arrowGames;
    public GameObject currentGame;
    public int randomInt;
    public bool foundNextArrow;
    public int nextArrow;
    public BoolData start;
    public BoolData playing;
    public BoolData leftButton;
    public BoolData rightButton;
    public int arrow = 0;
    public IntData weaponMat;
    public ListData arrowPositions;
    public float matAdj;

    public WeaponStats weaponStats;

    public GameController GC;

    public Text overlay;

    public CurrentContract currentContract;

    // Start is called before the first frame update
    void Start()
    {
        //resetting arrow transforms at new game.
        nextArrow = 0;
        arrowPositions.listOver = false;
        arrowPositions.listSet = false;
        arrowPositions.number = 0;
        matAdj = .3f;

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
            currentGame.transform.Translate(0, -1 * matAdj * Time.deltaTime, 0);
            
        }

        if (arrowPositions.listOver == true)
        {
            Destroy(currentGame);
            StartCoroutine(scoreDisplay());

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightButton.value = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftButton.value = true;
        }

    }

    public IEnumerator initializeGame()
    {
        start.value = false;
        arrowPositions.positionValue.Clear();
        arrowPositions.boolValue.Clear();
        randomInt = Random.Range(0, arrowGames.Length - 1);
        StartCoroutine(countDown());
        currentGame = Instantiate(arrowGames[randomInt]);
        arrow = 0;
        yield return new WaitForSeconds(0f);

    }

    public IEnumerator scoreDisplay()
    {
        overlay.text = weaponStats.smeltScore.ToString();
        yield return new WaitForSeconds(2f);
        GC.startForging();
    }


    public IEnumerator countDown()
    {

        yield return new WaitForSeconds(0f);
        overlay.text = "Ready...";
        yield return new WaitForSeconds(2f);
        overlay.text = "Go!";
        yield return new WaitForSeconds(1f);
        overlay.text = null;

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
