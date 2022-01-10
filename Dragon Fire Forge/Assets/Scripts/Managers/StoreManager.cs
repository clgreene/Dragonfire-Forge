using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    /*
    public Button Steel;
    public Button Haderite;
    public Button Mythril;
    public Button Asterite;
    public Button Sideaxe;
    public Button Rapier;
    public Button Mace;
    /*
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    public Button Steel;
    */

    public inventoryData inv;

    public BoolData SideAxe;
    public BoolData Rapier;
    public BoolData Mace;

    public Text steelQty;
    public Text haderiteQty;
    public Text mythrilQty;
    public Text asteriteQty;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        steelQty.text = inv.steel.ToString();
        haderiteQty.text = inv.haderite.ToString();
        mythrilQty.text = inv.mythril.ToString();
        asteriteQty.text = inv.asterite.ToString();
    }

    public void purchaseSteel()
    {
        if(inv.money < 1000)
        {
            Debug.Log("Not enough Money.");
        }

        else
        {
            inv.money -= 1000;
            inv.steel += 10;
        }

    }

    public void purchaseHaderite()
    {
        if (inv.money < 2500)
        {
            Debug.Log("Not enough Money.");
        }

        else
        {
            inv.money -= 2500;
            inv.haderite += 10;
        }
    }

    public void purchaseMythril()
    {
        if (inv.money < 5000)
        {
            Debug.Log("Not enough Money.");
        }

        else
        {
            inv.money -= 5000;
            inv.mythril += 10;
        }
    }

    public void purchaseAsterite()
    {
        if (inv.money < 8000)
        {
            Debug.Log("Not enough Money.");
        }

        else
        {
            inv.money -= 8000;
            inv.asterite += 10;
        }
    }

    public void purchaseSideAxe(Button but)
    {
        if(inv.money < 10000)
        {
            Debug.Log("No Money");
        }
        else
        {
            SideAxe.value = true;
            but.interactable = false;
        }

    }

    public void purchaseRapier(Button but)
    {
        if (inv.money < 10000)
        {
            Debug.Log("No Money");
        }
        else
        {
            Rapier.value = true;
            but.interactable = false;
        }
    }

    public void purchaseMace(Button but)
    {
        if (inv.money < 10000)
        {
            Debug.Log("No Money");
        }
        else
        {
            Mace.value = true;
            but.interactable = false;
        }
    }

}
