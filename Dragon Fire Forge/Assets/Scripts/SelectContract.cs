using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectContract : MonoBehaviour
{

    public ContractData selectedContract;
    public ContractData currentContract;

    public GameObject contractHighlight;

    public GameObject acceptButton;

    public GameObject highlightOne;
    public GameObject highlightTwo;
    public GameObject highlightThree;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void selectContract()
    {
        highlightOne.SetActive(false);
        highlightTwo.SetActive(false);
        highlightThree.SetActive(false);

        contractHighlight.SetActive(true);

        currentContract = selectedContract;

        acceptButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
