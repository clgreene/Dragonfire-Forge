using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryController : MonoBehaviour
{


    public Button[] inventorySelection;
    public Image[] inventoryImages;
    public IntData activeItem;

    public EmoteData emotes;

    public ActiveInventory activeInv;

    public PlayerAnimationController animationCont;

    bool gunHeld;

    // Start is called before the first frame update
    void Start()
    {
        animationCont = FindObjectOfType<PlayerAnimationController>();

        inventorySelection[activeItem.value].interactable = true;

        for (int i = 0; i < 8; i++)
        {
            if (i != activeItem.value)
            {
                inventorySelection[i].interactable = false;
            }
        }

        if (activeInv.activeInventory[activeItem.value] == null)
        {
            if (gunHeld == true)
            {
                animationCont.returnToOrigin();
                gunHeld = false;
            }
        }
        else if (activeInv.activeInventory[activeItem.value].isGun == true)
        {
            animationCont.equipGun();
            gunHeld = true;
        }
        else
        {
            if (gunHeld == true)
            {
                animationCont.returnToOrigin();
                gunHeld = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {



        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(activeItem.value < 7) activeItem.value++;

            inventorySelection[activeItem.value].interactable = true;

            for (int i = 0; i < 8; i++)
            {
                if(i != activeItem.value)
                {
                    inventorySelection[i].interactable = false;
                }
            }

            if (activeInv.activeInventory[activeItem.value] == null)
            {
                if (gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    gunHeld = false;
                }
            }
            else if (activeInv.activeInventory[activeItem.value].isGun == true)
            {
                animationCont.equipGun();
                gunHeld = true;
            }
            else
            {
                if (gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    gunHeld = false;
                }
            }

        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (activeItem.value > 0) activeItem.value--;

            inventorySelection[activeItem.value].interactable = true;

            for (int i = 0; i < 8; i++)
            {
                if (i != activeItem.value)
                {
                    inventorySelection[i].interactable = false;
                }
            }

            if (activeInv.activeInventory[activeItem.value] == null)
            {
                if (gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    gunHeld = false;
                }
            }
            else if (activeInv.activeInventory[activeItem.value].isGun == true)
            {
                animationCont.equipGun();
                gunHeld = true;
            }
            else
            {
                if (gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    gunHeld = false;
                }
            }

        }
    }

    public void updateInventory()
    {

    }
}
