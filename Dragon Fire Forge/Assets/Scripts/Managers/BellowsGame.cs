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

    public ContractData currentContract;

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

        }
        
        if (arrowPositions.listOver == false && arrowPositions.listSet == true)
        {
            currentGame.transform.Translate(0, -1 * matAdj * Time.deltaTime, 0);
            
        }

        if (arrowPositions.listOver == true)
        {
            Destroy(currentGame);
            StartCoroutine(scoreDisplay());
            arrowPositions.listOver = false;
            arrowPositions.listSet = false;
            start.value = false;
            arrowPositions.listOver = false;

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
        yield return new WaitForSeconds(3f);
        currentGame = Instantiate(arrowGames[randomInt]);
        arrow = 0;

    }

    public IEnumerator scoreDisplay()
    {
        overlay.text = weaponStats.smeltScore.ToString() + "%";
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
