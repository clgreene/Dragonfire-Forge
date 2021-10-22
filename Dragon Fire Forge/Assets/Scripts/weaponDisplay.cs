using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponDisplay : MonoBehaviour
{
    //weapons
    public GameObject[] broadSword;
    public GameObject[] longSword;
    public GameObject[] claymore;
    public GameObject[] katana;
    public GameObject[] mace;
    public GameObject[] bowie;
    public GameObject[] throwingKnives;
    public GameObject[] shield;


    //stars
    public GameObject oneStarWeapon;
    public GameObject twoStarWeapon;
    public GameObject threeStarWeapon;
    public GameObject fourStarWeapon;
    public GameObject fiveStarWeapon;
    public GameObject oneStarContract;
    public GameObject twoStarContract;
    public GameObject threeStarContract;
    public GameObject fourStarContract;
    public GameObject fiveStarContract;

    public GameObject weapon;

    public GameObject[] currentWeapon;

    public WeaponStats weaponStats;

    public float modifier;

    public BoolData tutorialActive;

    public GameObject tutorialHideBox;

    public GameController GC;



    public void displayWeapon()
    {
        //hiding all the stars
        oneStarWeapon.SetActive(false);
        twoStarWeapon.SetActive(false);
        threeStarWeapon.SetActive(false);
        fourStarWeapon.SetActive(false);
        fiveStarWeapon.SetActive(false);

        oneStarContract.SetActive(false);
        twoStarContract.SetActive(false);
        threeStarContract.SetActive(false);
        fourStarContract.SetActive(false);
        fiveStarContract.SetActive(false);

        //set weapon type
        switch (weaponStats.weaponType)
        {
            case 0:
                currentWeapon = broadSword;
                break;
            case 1:
                currentWeapon = longSword;
                break;
            case 2:
                currentWeapon = claymore;
                break;
            case 3:
                currentWeapon = katana;
                break;
            case 4:
                currentWeapon = mace;
                break;
            case 5:
                currentWeapon = bowie;
                break;
            case 6:
                currentWeapon = throwingKnives;
                break;
            case 7:
                currentWeapon = shield;
                break;
        }

        //instantiate weapon based on material
        weapon = Instantiate(currentWeapon[weaponStats.weaponMat]);

        //set material modifier
        switch (weaponStats.weaponMat)
        {
            case 0:
                modifier = 1;
                break;
            case 1:
                modifier = 1.5f;
                break;
            case 2:
                modifier = 2;
                break;
            case 3:
                modifier = 3;
                break;
        }

        //hiding normal game elements for tutorial elements
        if (tutorialActive.value == true)
        {
            tutorialHideBox.SetActive(true);

            if (weaponStats.weaponScore > 10) oneStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 30) twoStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 50) threeStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 70) fourStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 90) fiveStarWeapon.SetActive(true);

        }

        //displaying scores and earned money / xp
        if (tutorialActive.value == false)
        {
            if (weaponStats.weaponScore > 10) oneStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 30) twoStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 50) threeStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 70) fourStarWeapon.SetActive(true);
            if (weaponStats.weaponScore > 90) fiveStarWeapon.SetActive(true);

            if (weaponStats.contractScore > 10) oneStarContract.SetActive(true);
            if (weaponStats.contractScore > 10) twoStarContract.SetActive(true);
            if (weaponStats.contractScore > 10) threeStarContract.SetActive(true);
            if (weaponStats.contractScore > 10) fourStarContract.SetActive(true);
            if (weaponStats.contractScore > 10) fiveStarContract.SetActive(true);

            //reward money based on contract score * weapon mat modifier

            //reward rep based on weapon and contract average score * mat modifier
        }



    }


    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
