using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public IntData lineNumber;

    public IntData[] currentLineSize;

    public IntData weaponMat;

    public bool stopped;

    public bool routineFinished;

    public bool reverse;

    int linePosition;
    


    // Start is called before the first frame update
    void Start()
    {
        currentLine = lineOne;
        routineFinished = true;
        lineNumber.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (lineNumber.value)
        {
            case 0:
                currentLine = lineOne;
                break;
        }

        

        if (routineFinished == true) StartCoroutine(UpdateSpeed(weaponMat.value));

        

        //UpdateSpeed(weaponMat.value, currentLine[lineNumber.value]);


    }

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

        for (int i = 0; i < 18; i++)
        {
            currentLine[i].SetActive(false);
        }

        for (int lineSize = 0; lineSize < currentLineSize[lineNumber.value].value; lineSize++)
        {

            currentLine[lineSize + linePosition].SetActive(true);
        }

        yield return new WaitForSeconds(waitTime);

        if (reverse == false)
        {
            linePosition++;
        }

        if (linePosition + currentLineSize[lineNumber.value].value > 18)
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

        routineFinished = true;

    }
}
