using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playEmote(string newState)
    {
        
    }

    public void equipGun()
    {
        animator.Play("equipGun");
    }

    public void returnToOrigin()
    {
        animator.Play("returnToOrigin");
    }
    

}
