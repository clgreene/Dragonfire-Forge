using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteDisplay : MonoBehaviour
{

    public IntData emoteWheelInt;
    public GameObject selectionOne;
    public GameObject selectionTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void swapDisplay()
    {

        switch (emoteWheelInt.value)
        {
            case 0:
                selectionOne.SetActive(true);
                selectionTwo.SetActive(false);
                break;
            case 1:
                selectionOne.SetActive(false);
                selectionTwo.SetActive(true);
                break;
        }

    }
}
