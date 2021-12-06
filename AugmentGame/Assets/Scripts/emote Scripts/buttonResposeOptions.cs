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
            buttonOne.enabled = emotes.wave;
            buttonTwo.enabled = emotes.fuckOff;
            buttonThree.enabled = emotes.bringItOn;
            buttonFour.enabled = emotes.salute;
            buttonFive.enabled = emotes.thumbsUp;
            buttonSix.enabled = emotes.surrender;
            buttonSeven.enabled = emotes.watchingYou;
            buttonEight.enabled = emotes.shrug;
        }

        else if(emoteWheelInt.value == 1)
        {

        }

        else if(emoteWheelInt.value == 2)
        {

        }


    }
}
