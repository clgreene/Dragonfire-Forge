using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BellowsGame : MonoBehaviour
{

    public GameObject[] arrowGames;
    public GameObject currentGame;
    public int randomInt = 1;
    public BoolData start;
    public BoolData playing;
    public int arrow = 0;
    public Vector3 arrowPos;
    public int weaponMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start.value == true)
        {
            StartCoroutine(initializeGame());

            

            //pull arrow array/list
            //locate arrow based on arrow number in array - object location
            //if mousebuttondown then access arrow position, play arrow animation based on position, and hide arrow until off screen (unless game object resets itself when reused, then just hide arrow)
            //if arrow position is past too far position, play missed animation at position, and hide arrow
            //increase arrow number by one
            //if arrow number is larger than list, start is false.


        }
        if (playing.value == true)
        {
            currentGame.transform.Translate(0, -1 * Time.deltaTime, 0);
            //arrowPos = new Vector3(currentGame.GetComponent<arrowList(arrow);
        }
    }

    public IEnumerator initializeGame()
    {
        start.value = false;
        yield return new WaitForSeconds(0f);
        playing.value = true;
        randomInt = Random.Range(1, arrowGames.Length);
        currentGame = Instantiate(arrowGames[randomInt - 1]);
        StartCoroutine(countDown());
        weaponMat = 1;
        arrow = 0;

    }


    public IEnumerator countDown()
    {

        yield return new WaitForSeconds(0f);
        //play start animation



    }


}
