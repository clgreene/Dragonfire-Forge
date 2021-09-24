using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//This is a dialogue trigger script to be used with my StringListOperator script, and StringListData and IntData scriptable objects.
//This script triggers a certain NPCs dialogue.
//The Logic starts here with the Dialogue Trigger

//This is a unique item script. Multiple items with different dialogue will need to have this script attached to them, with their dialogue associated with them. 



public class DialogueTrigger : MonoBehaviour
{

	//establishing Unity Events for dialogue events
	public UnityEvent TriggerCycleEvent, TriggerExitEvent, TriggerSetEvent, TriggerExitFunction;

	//compartmentalizing a current string holder and assigning it a string of dialogue
	public CurrentString currentString;
	public StringListData dialogue;



	//Setting the correct dialogue for where you're at in the game. 
	public void startDialogue()
	{
		dialogue.exitEvent = TriggerExitFunction;
		currentString.value = dialogue; //ressetting the currentString to the specific dialogue we want
		TriggerSetEvent.Invoke(); //now we evoke the set dialogue fundtion to enter the dialogue screen - GO TO StringListOperator
		
	}


	//Cycling through and updating the UI with the dialogue loaded in from above;
	public void cycleDialogue()
	{
		
		TriggerCycleEvent.Invoke();
		
		
	}


	//resetting dialogue to begining of cycle
	public void endDialogue()
	{
		TriggerExitEvent.Invoke();
	}


}
