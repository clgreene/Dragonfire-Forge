using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialButton : MonoBehaviour
{

    public int matNumber;
    public IntData currentMatNumber;


    public void matButton()
    {
        currentMatNumber.value = matNumber;
    }

}
