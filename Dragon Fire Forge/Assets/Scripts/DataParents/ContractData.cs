using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
public class ContractData : ScriptableObject
{
    //random lists to draw from
    public Sprite[] heroIcons;
    public string[] heroNames;
    public string[] heroMonikers;

    //contract info
    public Sprite heroIcon;
    public string heroName;
    public string moniker;
    public int race;
    public int enemy;
    public int heroClass;

    




    public void createContract()
    {
        string[] heroNames = { "Hador ", "Vintel ", "Di ", "Elforth ", "Rial ", "Morfra ", "Ike ", "Sygel ", "Brood ", "Corin ", "Eve ", "Lorel ", "Mook ", "Stain " };
        string[] heroMonikers = { "The Brave", "The Bold", "The Reckless", "The Bloodthirsty", "The Bloody", "The Vagrant", "The Unstoppable", "The Unhinged", "The Faithful", "The Vengeful", "The Feared", "The Scavenger", "The Devilish" };

        heroIcon = heroIcons[Random.Range(0, heroIcons.Length - 1)];
        heroName = heroNames[Random.Range(0, heroNames.Length - 1)];
        moniker = heroMonikers[Random.Range(0, heroMonikers.Length - 1)];
        race = Random.Range(0, 3);
        enemy = Random.Range(0, 3);
        heroClass = Random.Range(0, 3);

    }


}
