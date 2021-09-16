using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BellowsGame : MonoBehaviour
{

    public GameObject[] arrowGames;
    private GameObject currentGame;
    public int randomInt;
    public BoolData start;
    public int arrow = 0;
    public int weaponMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            randomInt = Random.Range(0, arrowGames.Length);
            currentGame = Instantiate(arrowGames[randomInt]);
            StartCoroutine(countDown());
            weaponMat = 1;
            arrow = 0;

            while (start == true)
            {
                currentGame.transform.position = new Vector2(0, -1 * Time.deltaTime);
            }

            //pull arrow array/list
            //locate arrow based on arrow number in array - object location
            //if mousebuttondown then access arrow position, play arrow animation based on position, and hide arrow until off screen (unless game object resets itself when reused, then just hide arrow)
            //if arrow position is past too far position, play missed animation at position, and hide arrow
            //increase arrow number by one
            //if arrow number is larger than list, start is false.


        }
    }

    public IEnumerator countDown()
    {

        yield return new WaitForSeconds(0f);
        //play start animation



    }


}
