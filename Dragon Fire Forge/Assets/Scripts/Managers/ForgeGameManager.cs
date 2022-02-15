using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForgeGameManager : MonoBehaviour
{

    public GameObject[] lineOne;
    public GameObject[] lineTwo;
    public GameObject[] lineThree;
    public GameObject[] lineFour;
    public GameObject[] lineFive;
    public GameObject[] lineSix;
    public GameObject[] lineSeven;
    public GameObject[] lineEight;
    public GameObject[] lineNine;
    public GameObject[] lineTen;
    public GameObject[] lineEleven;
    public GameObject[] lineTwelve;
    public GameObject[] lineThirteen;
    public GameObject[] lineFourteen;
    public GameObject[] lineFifteen;
    public GameObject[] lineSixteen;
    public GameObject[] lineSeventeen;
    public GameObject[] lineEighteen;
    public GameObject[] lineNineteen;

    public GameObject[] currentLine;
    public GameObject[] previousLine;

    public IntArrayData currentEdge;

    public IntData lineNumber;

    public IntArrayData currentLineSize;

    public IntData weaponMat;

    public bool stopped;

    public bool routineFinished;

    public bool reverse;

    public bool firstLine;

    public BoolData playing;

    public int linePosition;

    float activeAmount;
    public float succesfulAmount;

    public GameController GC;

    public Text overlay;

    public ContractData currentContract;

    public WeaponStats currentWeapon;


    // Start is called before the first frame update
    void Start()
    {
        playing.value = false;
        currentLine = lineOne;
        previousLine = null;
        routineFinished = true;
        lineNumber.value = 0;
        activeAmount = 0;
        succesfulAmount = 0;
        firstLine = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (playing.value == true)
        {


            //updating the current and previous lines
            switch (lineNumber.value)
            {
                case 0:
                    currentLine = lineOne;
                    break;
                case 1:
                    currentLine = lineTwo;
                    previousLine = lineOne;
                    break;
                case 2:
                    currentLine = lineThree;
                    previousLine = lineTwo;
                    break;
                case 3:
                    currentLine = lineFour;
                    previousLine = lineThree;
                    break;
                case 4:
                    currentLine = lineFive;
                    previousLine = lineFour;
                    break;
                case 5:
                    currentLine = lineSix;
                    previousLine = lineFive;
                    break;
                case 6:
                    currentLine = lineSeven;
                    previousLine = lineSix;
                    break;
                case 7:
                    currentLine = lineEight;
                    previousLine = lineSeven;
                    break;
                case 8:
                    currentLine = lineNine;
                    previousLine = lineEight;
                    break;
                case 9:
                    currentLine = lineTen;
                    previousLine = lineNine;
                    break;
                case 10:
                    currentLine = lineEleven;
                    previousLine = lineTen;
                    break;
                case 11:
                    currentLine = lineTwelve;
                    previousLine = lineEleven;
                    break;
                case 12:
                    currentLine = lineThirteen;
                    previousLine = lineTwelve;
                    break;
                case 13:
                    currentLine = lineFourteen;
                    previousLine = lineThirteen;
                    break;
                case 14:
                    currentLine = lineFifteen;
                    previousLine = lineFourteen;
                    break;
                case 15:
                    currentLine = lineSixteen;
                    previousLine = lineFifteen;
                    break;
                case 16:
                    currentLine = lineSeventeen;
                    previousLine = lineSixteen;
                    break;
                case 17:
                    currentLine = lineEighteen;
                    previousLine = lineSeventeen;
                    break;
                case 18:
                    currentLine = lineNineteen;
                    previousLine = lineEighteen;
                    break;

            }


            //updating the line position
            if (routineFinished == true) StartCoroutine(UpdateSpeed(weaponMat.value));

            //stop line movement and go to the next line
            if (stopped == true)
            {
                lineNumber.value++;
                if (firstLine == true)
                {
                    for (int j = 0; j < ((25 - currentLineSize.value[lineNumber.value - 1]) / 2); j++)
                    {
                        currentLine[j].SetActive(false);
                        currentLine[24 - j].SetActive(false);
                    }

                    for (int i = 0; i < 25; i++)
                    {
                        if (currentLine[i].activeSelf)
                        {
                            succesfulAmount++;
                        }
                        
                    }
                }
                if (firstLine == false)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        //deleting overhanging lines
                        if (currentLine[i].activeSelf != previousLine[i].activeSelf)
                        {
                            currentLine[i].SetActive(false);
                        }

                        //delete lines not centered
                        
                        for (int j = 0; j < ((25 - currentLineSize.value[lineNumber.value - 1])/2); j++)
                        {
                            currentLine[j].SetActive(false);
                            currentLine[24 - j].SetActive(false);
                        }

                        if (currentLine[i].activeSelf)
                        {
                            activeAmount++;
                            succesfulAmount++;
                        }

                    }

                    //ending the update loop
                    if (activeAmount == 0)
                    {
                        playing.value = false;

                        StartCoroutine(displayScore());

                    }

                    activeAmount = 0;



                }

                firstLine = false;
                stopped = false;
            }
        }

    }

    //stop line call
    public void forgeButton()
    {
        stopped = true;
    }

    public IEnumerator displayScore()
    {

        lineNumber.value = 0;
        int score = (int)(succesfulAmount * 100 / GC.weaponInfo.weaponEdgeVolume);
        GC.weaponInfo.forgeScore = score;
        currentWeapon.forgeScore = score;
        overlay.text = score.ToString() + "%";
        yield return new WaitForSeconds(2f);
        GC.ForgeGame.SetActive(false);
        overlay.text = "";
        GC.displayWeapon();

        //Resetting Game for next time around!!!!
        currentLine = lineOne;
        routineFinished = true;
        previousLine = null;
        lineNumber.value = 0;
        activeAmount = 0;
        succesfulAmount = 0;
        firstLine = true;
        linePosition = 0;


        for (int i = 0; i < 19; i++)
        {
            
            switch (i)
            {
                case 0:
                    currentLine = lineOne;
                    break;
                case 1:
                    currentLine = lineTwo;
                    previousLine = lineOne;
                    break;
                case 2:
                    currentLine = lineThree;
                    previousLine = lineTwo;
                    break;
                case 3:
                    currentLine = lineFour;
                    previousLine = lineThree;
                    break;
                case 4:
                    currentLine = lineFive;
                    previousLine = lineFour;
                    break;
                case 5:
                    currentLine = lineSix;
                    previousLine = lineFive;
                    break;
                case 6:
                    currentLine = lineSeven;
                    previousLine = lineSix;
                    break;
                case 7:
                    currentLine = lineEight;
                    previousLine = lineSeven;
                    break;
                case 8:
                    currentLine = lineNine;
                    previousLine = lineEight;
                    break;
                case 9:
                    currentLine = lineTen;
                    previousLine = lineNine;
                    break;
                case 10:
                    currentLine = lineEleven;
                    previousLine = lineTen;
                    break;
                case 11:
                    currentLine = lineTwelve;
                    previousLine = lineEleven;
                    break;
                case 12:
                    currentLine = lineThirteen;
                    previousLine = lineTwelve;
                    break;
                case 13:
                    currentLine = lineFourteen;
                    previousLine = lineThirteen;
                    break;
                case 14:
                    currentLine = lineFifteen;
                    previousLine = lineFourteen;
                    break;
                case 15:
                    currentLine = lineSixteen;
                    previousLine = lineFifteen;
                    break;
                case 16:
                    currentLine = lineSeventeen;
                    previousLine = lineSixteen;
                    break;
                case 17:
                    currentLine = lineEighteen;
                    previousLine = lineSeventeen;
                    break;
                case 18:
                    currentLine = lineNineteen;
                    previousLine = lineEighteen;
                    break;

            }
            for (int l = 0; l < 25; l++)
            {
                currentLine[l].SetActive(false);
            }


        }

    }


    //bounce lines back and forth
    public IEnumerator UpdateSpeed(int speed)
    {
        routineFinished = false;

        float waitTime = .75f;

        switch (speed)
        {
            case 0:
                waitTime = .15f;
                break;
            case 1:
                waitTime = .09f;
                break;
            case 2:
                waitTime = .06f;
                break;
            case 3:
                waitTime = .03f;
                break;
        }

        for (int i = 0; i < 25; i++)
        {
            currentLine[i].SetActive(false);
        }

        for (int lineSize = 0; lineSize < currentLineSize.value[lineNumber.value]; lineSize++)
        {

            currentLine[lineSize + linePosition].SetActive(true);

            if (currentLineSize.value[lineNumber.value] == 0)
            {
                playing.value = false;
                GC.displayWeapon();
            }

        }

        yield return new WaitForSeconds(waitTime);

        if (playing.value == true)
        {
            if (reverse == false)
            {
                linePosition++;
            }

            if (linePosition + currentLineSize.value[lineNumber.value] > 25)
            {
                reverse = true;
                linePosition--;
            }

            if (reverse == true)
            {
                linePosition--;
            }

            if (linePosition == 0)
            {
                reverse = false;
            }
        }

        routineFinished = true;

    }
}
