using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueRunner : MonoBehaviour
{

    public CollectedData activeDialogue;

    public Text dialogueText;

    int sentence;
    bool started;



    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = null;
        sentence = 0;
        started = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startDialogue()
    {
        sentence = 0;
        dialogueText.text = activeDialogue.stringList[sentence];
        started = true;

        while (started == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                sentence++;
                if(sentence == activeDialogue.stringList.Count)
                {
                    started = false;
                }
                else
                {
                    dialogueText.text = activeDialogue.stringList[sentence];
                }

            }
        }


    }
}
