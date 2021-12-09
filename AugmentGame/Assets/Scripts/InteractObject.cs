using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractObject : MonoBehaviour
{

    public UnityEvent interactDefault, interactStart, interactCycle, interactRespond, interactEnd;

    public GameObject interactIcon;

    bool interactEnabled;
    bool started;
    public bool ended;
    public bool response;


    private void Start()
    {
        interactIcon.SetActive(false);
        started = false;
        interactEnabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactIcon.SetActive(true);
            interactEnabled = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) interactEnabled = true;
    }

    private void Update()
    {
        if (interactEnabled == true && Input.GetKeyDown(KeyCode.F))
        {

            interactIcon.SetActive(false);

            if (started == true && ended == false)
            {
                if (response == true) interactRespond.Invoke();
                else interactCycle.Invoke();
            }

            else if (response == true)
            {
                interactRespond.Invoke();
            }

            else if (ended == true)
            {
                interactEnd.Invoke();
                interactIcon.SetActive(true);
                ended = false;
                started = false;
                
            }

            else
            {
                interactStart.Invoke();
                started = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactIcon.SetActive(false);
            interactEnabled = false;
        }
    }

}
