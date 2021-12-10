using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public CollectedData timeData;

    public Text minutes;
    public Text hours;

    public EmoteData emotes;

    public GameObject daylight;
    Color alpha;

    // Start is called before the first frame update
    void Start()
    {
        timeData.boolValue = true;
        alpha = daylight.GetComponent<SpriteRenderer>().color;
        emotes.reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) Screen.fullScreen = !Screen.fullScreen;

        //updating time of day.
        if (timeData.boolValue == true)
        {
            StartCoroutine(minuteTick());
            timeData.boolValue = false;
        }

        minutes.text = timeData.intList[0].ToString("D2");
        hours.text = timeData.intList[1].ToString("D2");

        //Setting sun
        if (timeData.intList[1] == 20)
        {
            if (timeData.boolList[0] == true)
            {
                StartCoroutine(nightlightShift());
                timeData.boolList[0] = false;
            }

        }

        //Rising sun
        if (timeData.intList[1] == 7)
        {
            if (timeData.boolList[0] == false)
            {
                StartCoroutine(daylightShift());
                timeData.boolList[0] = true;
            }
            
        }
        
    }

    public IEnumerator minuteTick()
    {
        yield return new WaitForSeconds(2f);
        if (timeData.intList[0] < 60) timeData.intList[0]++;

        if (timeData.intList[0] == 60)
        {
            timeData.intList[0] = 0;
            if (timeData.intList[1] < 24) timeData.intList[1]++;

            if (timeData.intList[1] == 24) timeData.intList[1] = 0;
        }

        timeData.boolValue = true;
    }

    public IEnumerator nightlightShift()
    {
        while (daylight.GetComponent<SpriteRenderer>().color.a < 0.4f)
        {
            yield return new WaitForSeconds(1f);
            alpha.a += 0.01f;
            daylight.GetComponent<SpriteRenderer>().color = alpha;
        }
    }

    public IEnumerator daylightShift()
    {
        while (daylight.GetComponent<SpriteRenderer>().color.a > 0f)
        {
            yield return new WaitForSeconds(1f);
            alpha.a -= 0.01f;
            daylight.GetComponent<SpriteRenderer>().color = alpha;
        }
    }

}
