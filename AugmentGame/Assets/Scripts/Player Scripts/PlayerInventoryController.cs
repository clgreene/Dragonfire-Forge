using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryController : MonoBehaviour
{


    public Button[] inventorySelection;
    public int activeItem;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            if (i != activeItem)
            {
                inventorySelection[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(activeItem < 7) activeItem++;

            inventorySelection[activeItem].interactable = true;

            for (int i = 0; i < 8; i++)
            {
                if(i != activeItem)
                {
                    inventorySelection[i].interactable = false;
                }
            }

        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (activeItem > 0) activeItem--;

            inventorySelection[activeItem].interactable = true;

            for (int i = 0; i < 8; i++)
            {
                if (i != activeItem)
                {
                    inventorySelection[i].interactable = false;
                }
            }

        }
    }
}
