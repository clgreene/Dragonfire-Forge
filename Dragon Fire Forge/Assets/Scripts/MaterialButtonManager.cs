using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialButtonManager : MonoBehaviour
{
    public IntData steel;
    public IntData haderite;
    public IntData mithril;
    public IntData asterite;

    public GameObject steelButton;
    public GameObject haderiteButton;
    public GameObject mithrilButton;
    public GameObject asteriteButton;



    // Update is called once per frame
    void Update()
    {
        if (steel.value == 0)
        {
            steelButton.SetActive(false);
        }

        else steelButton.SetActive(true);

        if (haderite.value == 0)
        {
            haderiteButton.SetActive(false);
        }

        else haderiteButton.SetActive(true);

        if (mithril.value == 0)
        {
            mithrilButton.SetActive(false);
        }

        else mithrilButton.SetActive(true);

        if (asterite.value == 0)
        {
            asteriteButton.SetActive(false);
        }

        else asteriteButton.SetActive(true);

    }


}
