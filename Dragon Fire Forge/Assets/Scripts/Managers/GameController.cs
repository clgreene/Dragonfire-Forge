using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

////This is a Manager Class Script. One script for the whole game / scene.


public class GameController : MonoBehaviour
{

    public GameObject HomeScreen;
    public GameObject SaveSlotScreen;
    public GameObject LoadGameScreen;
    public GameObject ForgeScreen;
    public GameObject SmeltScreen;
    //public GameObject QuenchScreen;
    public GameObject Dialogue;
    //public GameObject Map;
    //public GameObject Contracts;
    public GameObject ForgeGame;
    public GameObject SmeltGame;
    public GameObject QuenchGame;
    public GameObject WeaponSelection;
    public GameObject PauseScreen;
    public WeaponStats weaponInfo;
    public GameObject WeaponDisplay;
    public GameObject CreditsScreen;
    public GameObject TutorialOption;
    public GameObject MatChoices;


    //forge elements
    public IntArrayData currentEdge;
    public IntArrayData standardEdge;
    public IntArrayData sharpEdge;
    public IntArrayData strongEdge;
    public IntArrayData bluntEdge;

    //bellows elements
    public BoolData startBellows;
    public IntData weaponMat;
    public IntData steel;
    public IntData haderite;
    public IntData mithril;
    public IntData asterite;

    public BoolData forgePlaying;


    private void Update()
    {

    }

    public void NewGame()
    {
        HomeScreen.SetActive(false);
        steel.value = 10;
        haderite.value = 0;
        mithril.value = 0;
        asterite.value = 0;
        TutorialOption.SetActive(true);
    }

    public void tutorial()
    {
        TutorialOption.SetActive(false);
        Dialogue.SetActive(true);
    }

    public void chooseMat()
    {
        Dialogue.SetActive(false);
        MatChoices.SetActive(true);
    }

    public void startContract()
    {
        Dialogue.SetActive(false);
        SmeltGame.SetActive(true);
        MatChoices.SetActive(false);
        startBellows.value = true;

    }

    public void startForging()
    {
        switch (weaponInfo.weaponEdge)
        {
            case 0:
                currentEdge.value = strongEdge.value;
                break;
            case 1:
                currentEdge.value = sharpEdge.value;
                break;
            case 2:
                currentEdge.value = strongEdge.value;
                break;
            case 3:
                currentEdge.value = bluntEdge.value;
                break;

        }

        ForgeScreen.SetActive(true);
        SmeltGame.SetActive(false);
        ForgeGame.SetActive(true);
        forgePlaying.value = true;
    }

    public void displayWeapon()
    {
        ForgeScreen.SetActive(false);
        ForgeGame.SetActive(false);


    }

    public void noTutorial()
    {
        TutorialOption.SetActive(false);
        //ForgeScreen.SetActive(true);
    }
}
