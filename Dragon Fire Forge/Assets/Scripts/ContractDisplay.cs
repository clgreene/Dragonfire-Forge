using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContractDisplay : MonoBehaviour
{

    public ContractData contract;

    public GameObject heroImage;
    public Text chosenName;
    public Text chosenTitle;
    public Text chosenEnemy;
    public Text chosenClass;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateContract()
    {
        contract.createContract();

        heroImage.GetComponent<Image>().sprite = contract.heroIcon;
        chosenName.text = contract.heroName;
        chosenTitle.text = contract.moniker;

        switch (contract.enemy)
        {
            case 0:
                chosenEnemy.text = "Orcs";
                break;
            case 1:
                chosenEnemy.text = "Dark Elves";
                break;
            case 2:
                chosenEnemy.text = "The Undead";
                break;
            case 3:
                chosenEnemy.text = "Arachnids";
                break;
        }
            
        switch (contract.heroClass)
        {
            case 0:
                chosenClass.text = "Knight";
                break;
            case 1:
                chosenClass.text = "Paladin";
                break;
            case 2:
                chosenClass.text = "Ranger";
                break;
            case 3:
                chosenClass.text = "Assassin";
                break;
        }
        
    }
}
