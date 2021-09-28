using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


//attach this script to buttons or actions that populate dialogue

public class DialogueSetter : MonoBehaviour
{

    public CurrentString currentString;
    public StringListData dialogue;
    public StringListOperator slo;
    public Text dialText;
    public UnityEvent dialogueEndFunction;

    public void setDialogue()
    {
        
        currentString.value = dialogue;
        slo.SetDialogueList(dialText);
        slo.dialogueEndFunction = dialogueEndFunction;


    }
}
