using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialButton : MonoBehaviour
{

    public int matNumber;
    public WeaponStats weaponStats;


    public void matButton()
    {
        weaponStats.weaponMat = matNumber;
    }

}
