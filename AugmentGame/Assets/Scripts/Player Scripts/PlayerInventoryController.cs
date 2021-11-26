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

        activeInv.setInventory();

        for (int i = 0; i < 8; i++)
        {
            inventoryImages[i].sprite = activeInv.activeInventory[i].icon;
            

            if (i != activeItem.value)
            {
                inventorySelection[i].interactable = false;
            }
        }

        if (activeInv.activeInventory[activeItem.value] == null)
        {
            if (emotes.gunHeld == true)
            {
                animationCont.returnToOrigin();
                emotes.gunHeld = false;
            }
        }
        else if (activeInv.activeInventory[activeItem.value].isGun == true)
        {
            animationCont.equipGun();
            emotes.gunHeld = true;
        }
        else
        {
            if (gunHeld == true)
            {
                animationCont.returnToOrigin();
                emotes.gunHeld = false;
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
                if (emotes.gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    emotes.gunHeld = false;
                }
            }
            else if (activeInv.activeInventory[activeItem.value].isGun == true)
            {
                animationCont.equipGun();
                emotes.gunHeld = true;
            }
            else
            {
                if (emotes.gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    emotes.gunHeld = false;
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
                if (emotes.gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    emotes.gunHeld = false;
                }
            }
            else if (activeInv.activeInventory[activeItem.value].isGun == true)
            {
                animationCont.equipGun();
                emotes.gunHeld = true;
            }
            else
            {
                if (emotes.gunHeld == true)
                {
                    animationCont.returnToOrigin();
                    emotes.gunHeld = false;
                }
            }

        }
    }

    public void updateInventory()
    {

    }
}
