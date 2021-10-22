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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
