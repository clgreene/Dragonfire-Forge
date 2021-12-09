using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonResposeOptions : MonoBehaviour
{

    public Button buttonOne;
    public Button buttonTwo;
    public Button buttonThree;
    public Button buttonFour;
    public Button buttonFive;
    public Button buttonSix;
    public Button buttonSeven;
    public Button buttonEight;

    public IntData emoteWheelInt;
    public EmoteData emotes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(emoteWheelInt.value == 0)
        {
            buttonOne.interactable = emotes.wave;
            buttonTwo.interactable = emotes.fuckOff;
            buttonThree.interactable = emotes.bringItOn;
            buttonFour.interactable = emotes.salute;
            buttonFive.interactable = emotes.thumbsUp;
            buttonSix.interactable = emotes.surrender;
            buttonSeven.interactable = emotes.watchingYou;
            buttonEight.interactable = emotes.shrug;
        }

        else if(emoteWheelInt.value == 1)
        {
            buttonOne.interactable = emotes.rockOut;
            buttonTwo.interactable = emotes.score;
            buttonThree.interactable = emotes.smoke;
            buttonFour.interactable = emotes.no;
            buttonFive.interactable = emotes.yes;
            buttonSix.interactable = emotes.facePalm;
            buttonSeven.interactable = emotes.oops;
            buttonEight.interactable = emotes.pullHair;
        }

        else if(emoteWheelInt.value == 2)
        {

        }


    }
}
