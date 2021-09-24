using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

////This is a Manager Class Script. One script for the whole game / scene.


public class GameController : MonoBehaviour
{

    public GameObject HomeScreen;
    public GameObject SaveSlotScreen;
    public GameObject LoadGameScreen;
    //public GameObject ForgeScreen;
    //public GameObject SmeltScreen;
    //public GameObject QuenchScreen;
    public GameObject Dialogue;
    //public GameObject Map;
    //public GameObject Contracts;
    //public GameObject ForgeGame;
    public GameObject SmeltGame;
    public GameObject QuenchGame;
    public GameObject WeaponSelection;
    public GameObject PauseScreen;
    public GameObject WeaponInfo;
    public GameObject WeaponDisplay;
    public GameObject CreditsScreen;
    public GameObject TutorialOption;


    public BoolData startBellows;
    public IntData weaponMat;

    public void NewGame()
    {
        HomeScreen.SetActive(false);
        TutorialOption.SetActive(true);
    }

    public void tutorial()
    {
        TutorialOption.SetActive(false);
        //ForgeScreen.SetActive(true);
        Dialogue.SetActive(true);
    }

    public void startContract()
    {
        Dialogue.SetActive(false);
        SmeltGame.SetActive(true);
        weaponMat.value = 0;
        startBellows.value = true;

    }

    public void noTutorial()
    {
        TutorialOption.SetActive(false);
        //ForgeScreen.SetActive(true);
    }
}
