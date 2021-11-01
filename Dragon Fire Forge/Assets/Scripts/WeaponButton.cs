using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponButton : MonoBehaviour
{

    public BoolData purchased;

    public Button activated;

    public int weaponType;

    public WeaponStats weaponInfo;

    public GameObject acceptButton;

    public GameObject selected;

    public GameObject[] selectionList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (purchased.value == true) activated.interactable = true;

    }

    public void selectWeapon()
    {
        for (int i = 0; i < selectionList.Length; i++)
        {
            selectionList[i].SetActive(false);
        }

        selected.SetActive(true);

        weaponInfo.weaponType = weaponType;
        acceptButton.SetActive(true);

    }
}
