using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class WeaponStats : ScriptableObject
{
    //weapon characteristics
    public int weaponType;
    public int weaponMat;
    public int weaponEnch;
    public int weaponEdge;
    public int weaponEdgeVolume;

    //weapon qualitys
    public int smeltScore;
    public int forgeScore;
    public int quenchScore;
    public int weaponScore;
    public int contractScore;

    //weapon modifiers
    int matMod;



    public void calcWeaponScore()
    {
        switch (weaponMat)
        {
            case 0:
                matMod = 40;
                break;
            case 1:
                matMod = 25;
                break;
            case 2:
                matMod = 10;
                break;
            case 3:
                matMod = 0;
                break;
        }

        weaponScore = ((smeltScore + forgeScore) / 2) - matMod;

    }


    
}
