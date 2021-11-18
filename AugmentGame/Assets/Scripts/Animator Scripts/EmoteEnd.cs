using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteEnd : StateMachineBehaviour
{
    public EmoteData emotes;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        emotes.yesInit = false;
        emotes.noInit = false;
        emotes.waveInit = false;
        emotes.scoreInit = false;
        emotes.thumbsUpInit = false;
        emotes.shrugInit = false;
        emotes.fuckOffInit = false;
        emotes.watchingYouInit = false;
        emotes.rockOutInit = false;
        emotes.facePalmInit = false;
        emotes.oopsInit = false;
        emotes.pullHairInit = false;
        emotes.saluteInit = false;
        emotes.bringItOnInit = false;
        emotes.surrenderInit = false;

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
