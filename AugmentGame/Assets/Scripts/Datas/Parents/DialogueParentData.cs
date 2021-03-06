using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialogueParentData : ScriptableObject
{

    public DialogueData startDialogue;
    public DialogueData currentDialogue;

    public bool initialized;

    public void initialize()
    {
        if (initialized == false)
        {
            currentDialogue = startDialogue;
            initialized = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
