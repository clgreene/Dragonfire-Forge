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



    public void displayWeapon()
    {
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

        weapon = Instantiate(currentWeapon[weaponStats.weaponMat]);


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
