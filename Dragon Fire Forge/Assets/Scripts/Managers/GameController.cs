using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

////This is a Manager Class Script. One script for the whole game / scene.


public class GameController : MonoBehaviour
{

    public GameObject HomeScreen;
    public GameObject ForgeButtons;
    public GameObject ForgeBanner;
    public GameObject ForgeScreen;
    public GameObject SmeltScreen;
    //public GameObject QuenchScreen;
    public GameObject Dialogue;
    public GameObject ContractScreen;
    public GameObject ForgeGame;
    public GameObject SmeltGame;
    //public GameObject QuenchGame;
    public GameObject WeaponSelection;
    public GameObject PauseScreen;
    public WeaponStats weaponInfo;
    public GameObject blackScreen;
    public GameObject WeaponDisplay;
    public GameObject CreditsScreen;
    public GameObject TutorialOption;
    public GameObject MatChoices;
    public GameObject MapScreen;


    //forge elements
    public IntArrayData currentEdge;
    public IntArrayData standardEdge;
    public IntArrayData sharpEdge;
    public IntArrayData strongEdge;
    public IntArrayData bluntEdge;

    //bellows elements
    public BoolData startBellows;
    public IntData weaponMat;

    //inventory texts
    public inventoryData inv;
    public Text money;
    public Text rep;
    public Text steel;
    public Text haderite;
    public Text mythril;
    public Text asterite;

    //contract elements
    public ContractDisplay contractOne;
    public ContractDisplay contractTwo;
    public ContractDisplay contractThree;
    public ContractData currentContract;


    public BoolData forgePlaying;
    public BoolData tutorialActive;

    public weaponDisplay weaponDisplay;

    public int day = 0;


    private void Update()
    {

        money.text = inv.money.ToString();
        if (inv.reputation < 100) rep.text = "Apprentice";
        else if (inv.reputation < 200) rep.text = "BlackSmith";
        else if (inv.reputation < 300) rep.text = "Honored";
        else if (inv.reputation < 400) rep.text = "Revered";
        else if (inv.reputation >= 400) rep.text = "Legendary";
        steel.text = inv.steel.ToString();
        haderite.text = inv.haderite.ToString();
        mythril.text = inv.mythril.ToString();
        asterite.text = inv.asterite.ToString();



    }

    public void openContracts()
    {
        ContractScreen.SetActive(true);
    }

    public void closeContracts()
    {
        ContractScreen.SetActive(false);
    }

    public void contractSelect()
    {
        
    }

    public void openMap()
    {
        MapScreen.SetActive(true);
    }

    public void closeMap()
    {
        MapScreen.SetActive(false);
    }

    public void openJournal()
    {

    }

    public void openShop()
    {

    }

    public void NewGame()
    {
        HomeScreen.SetActive(false);
        inv.reputation = 0;
        inv.money = 1000;
        inv.steel = 10;
        inv.haderite = 0;
        inv.mythril = 0;
        inv.asterite = 0;
        TutorialOption.SetActive(true);
    }

    public void tutorial()
    {
        TutorialOption.SetActive(false);
        tutorialActive.value = true;
        weaponInfo.weaponType = 0;
        inv.steel = 11;
        Dialogue.SetActive(true);
    }

    public void chooseMat()
    {
        Dialogue.SetActive(false);
        MatChoices.SetActive(true);
    }

    public void chooseWeapon()
    {
        WeaponSelection.SetActive(true);
    }

    public void startContract()
    {
        Dialogue.SetActive(false);
        WeaponSelection.SetActive(false);
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
                weaponInfo.weaponEdgeVolume = 200;
                break;
            case 1:
                currentEdge.value = sharpEdge.value;
                weaponInfo.weaponEdgeVolume = 141;
                break;
            case 2:
                currentEdge.value = strongEdge.value;
                weaponInfo.weaponEdgeVolume = 233;
                break;
            case 3:
                currentEdge.value = bluntEdge.value;
                weaponInfo.weaponEdgeVolume = 159;
                break;

        }

        ForgeScreen.SetActive(true);
        SmeltGame.SetActive(false);
        ForgeGame.SetActive(true);
        forgePlaying.value = true;
    }

    public void displayWeapon()
    {

        weaponInfo.calcWeaponScore();

        ForgeScreen.SetActive(false);
        ForgeGame.SetActive(false);
        blackScreen.SetActive(true);
        WeaponDisplay.SetActive(true);
        weaponDisplay.displayWeapon();

        //update day counter
        //update enemy map based on contract and weapon score


    }

    public void newDay()
    {
        Dialogue.SetActive(false);
        day++;
        ForgeBanner.SetActive(true);
        ForgeButtons.SetActive(true);
        contractOne.generateContract();
        contractTwo.generateContract();
        contractThree.generateContract();


    }

    public void TutorialEnd()
    {
        blackScreen.SetActive(false);
        WeaponDisplay.SetActive(false);
        weaponDisplay.tutorialHideBox.SetActive(false);
        Dialogue.SetActive(true);
        Destroy(weaponDisplay.weapon);

    }

    public void noTutorial()
    {
        TutorialOption.SetActive(false);
        newDay();
        //ForgeScreen.SetActive(true);
    }
}
