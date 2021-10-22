using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ContractData : ScriptableObject
{
    public GameObject[] heroIcons;
    public string[] heroNames;
    public string[] heroMonikers;

    public GameObject heroIcon;
    public string heroName;
    public string moniker;
    public int race;
    public int enemy;
    public int heroClass;
    




    // Start is called before the first frame update
    void Start()
    {
        string[] heroNames = { "Hador ", "Vintel ", "Di ", "Elforth ", "Rial ", "Morfra ", "Ike ", "Sygel ", "Brood ", "Corin ", "Eve ", "Lorel ", "Mook ", "Stain "};
        string[] heroMonikers = { "The Brave", "The Bold", "The Reckless", "The Bloodthirsty", "The Bloody", "The Vagrant", "The Unstoppable", "The Unhinged", "The Faithful", "The Vengeful", "The Feared", "The Scavenger", "The Devilish" };
    }



    void createContract()
    {
        heroIcon = heroIcons[Random.Range(0, heroIcons.Length - 1)];
        heroName = heroNames[Random.Range(0, heroNames.Length - 1)];
        moniker = heroMonikers[Random.Range(0, heroMonikers.Length - 1)];
        race = Random.Range(0, 3);
        enemy = Random.Range(0, 3);
        heroClass = Random.Range(0, 3);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
