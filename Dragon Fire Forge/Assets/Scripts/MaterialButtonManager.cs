using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialButtonManager : MonoBehaviour
{
    public inventoryData inv;

    public GameObject steelButton;
    public GameObject haderiteButton;
    public GameObject mithrilButton;
    public GameObject asteriteButton;



    // Update is called once per frame
    void Update()
    {
        if (inv.steel == 0)
        {
            steelButton.SetActive(false);
        }

        else steelButton.SetActive(true);

        if (inv.haderite == 0)
        {
            haderiteButton.SetActive(false);
        }

        else haderiteButton.SetActive(true);

        if (inv.mythril == 0)
        {
            mithrilButton.SetActive(false);
        }

        else mithrilButton.SetActive(true);

        if (inv.asterite == 0)
        {
            asteriteButton.SetActive(false);
        }

        else asteriteButton.SetActive(true);

    }


}
