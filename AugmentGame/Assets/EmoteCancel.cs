using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteCancel : StateMachineBehaviour
{
    public EmoteData emotes;
    public BoolData movementPause;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.anyKeyDown)
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
            emotes.hairPullInit = false;
            emotes.saluteInit = false;
            emotes.bringItOnInit = false;
            emotes.surrenderInit = false;
            emotes.smokeInit = false;

            emotes.emoteInitialized = false;

            movementPause.value = false;

            if (emotes.right == true)
            {
                if (emotes.gunHeld == true) animator.Play("GunIdleRight");
                else animator.Play("IdleRight");
            }
            else
            {
                if (emotes.gunHeld == true) animator.Play("GunIdleLeft");
                else animator.Play("idleLeft");
            }




        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
