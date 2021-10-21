using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialDragAndDrop : MonoBehaviour
{

    public int WeaponMat;
    public WeaponStats weaponStats;
    public GameObject[] MatSelection;
    public Transform[] buttonPos;
    public GameController GC;
    public bool matSelected;

    public Collider2D col;

    public GameObject material;

    // Start is called before the first frame update
    void Start()
    {
        matSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchPoint = Physics2D.OverlapPoint(touchPos);
                if (col == touchPoint)
                {
                    Debug.Log("ColliderWorks");
                    matSelected = true;
                    weaponStats.weaponMat = WeaponMat;
                    material = Instantiate(MatSelection[WeaponMat], buttonPos[WeaponMat]);

                }

            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (matSelected == true)
                {
                    material.transform.position = new Vector2(touchPos.x, touchPos.y);
                }
                
            }

            if (touch.phase == TouchPhase.Ended)
            {
                if (matSelected == true)
                {

                    if (material.transform.position.y < -0.25 && material.transform.position.y > -1)
                    {

                        GC.startContract();

                        Destroy(material);

                        matSelected = false;
                    }

                    else Destroy(material);
                    matSelected = false;
                }
                

            }




        }


    }
}
