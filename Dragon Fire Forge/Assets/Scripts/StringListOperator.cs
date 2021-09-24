using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This is a Manager class script that organizes and loads in correct dialogue for an NPCs dialogue trigger scripts. It needs the DialogueTrigger script, IntData and StringListData Scriptable Objects
//This scripts functions are called by dialogue trigger scripts from items or characters. 


public class StringListOperator : MonoBehaviour
{

    //establishing the dialogue #, a currentList for to load into the text, and all the available dialogue options
    public IntData dialogue;
    public CurrentString currentList;
    

    //establishing a returnValue string for dialogue statements, and an integer that will cycle through all statements in a single dialogue option
    public string returnValue;
    public int i = 0;

    //Logic for loading current dialogue list, called from the Dialogue Trigger Set Event
    public void SetDialogueList(Text obj)
    {

        returnValue = currentList.value.stringList[i];

        obj.text = returnValue;

    }

    //cycle through statement and update the returnValue as you go called from the Dialogue Trigger Cycle Event
    public void GetNextDialogue(Text obj)
    {
        if (i >= currentList.value.stringList.Count - 1)
        {
            ExitTextUI(obj);
        }

        else
        {
            i++;

            returnValue = currentList.value.stringList[i];

            obj.text = returnValue;
        }

    }

    //resetting dialogue text to first text option
    public void ExitTextUI(Text obj)
    {
        obj.text = null;
        i = 0;
        currentList.value.exitFunction();

    }

}
