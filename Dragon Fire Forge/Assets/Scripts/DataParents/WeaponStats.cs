using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class WeaponStats : ScriptableObject
{
    //weapon characteristics
    public IntData weaponType;
    public IntData weaponMat;
    public IntData weaponEnch;

    //weapon qualitys
    public IntData smeltScore;
    public IntData forgeScore;
    public IntData quenchScore;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
