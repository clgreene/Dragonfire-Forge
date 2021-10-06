using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialDragAndDrop : MonoBehaviour
{

    public IntData WeaponMat;
    public GameObject[] MatSelection;
    public Transform[] buttonPos;

    public GameObject material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Debug.Log("Getting Touched!");
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                if (WeaponMat.value != 0) material = Instantiate(MatSelection[WeaponMat.value], buttonPos[WeaponMat.value]);
                
            }

            if (touch.phase == TouchPhase.Moved)
            {
                material.transform.position = new Vector2(touchPos.x, touchPos.y);
            }

            if (touch.phase == TouchPhase.Ended)
            {


                if (material.transform.position.y < 4 && material.transform.position.y > 1)
                {

                }

                else Destroy(material);

            }



        }
    }
}
