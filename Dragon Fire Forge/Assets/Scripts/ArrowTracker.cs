using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTracker : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) Debug.Log("Right");
        if (Input.GetKeyDown(KeyCode.LeftArrow)) Debug.Log("Left");
    }
}
