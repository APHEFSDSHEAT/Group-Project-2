using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionKey : MonoBehaviour
{

    // THIS SCRIPT IS CHECKING IF THE PLAYER IS WITHIN RANGE OF THE DESIRED OBJECT (this script is just a gameobject attached as child)

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject interactionNotification;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange) // If we're in range to interact
        {
            if(Input.GetKeyDown(interactKey)) // And player presses key
            {
                interactAction.Invoke(); // Fire event
            }
        } 

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            isInRange = true;
            NotifyPlayer();
            //collision.gameObject.GetComponent<PlayerKeyManaging>().NotifyPlayer();
            //Debug.Log("Player is now IN range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            isInRange = false;
            DeNotifyPlayer();
            //collision.gameObject.GetComponent<PlayerKeyManaging>().DeNotifyPlayer();
            //Debug.Log("Player is now NOT in range");
        }
    }

    public void NotifyPlayer()
    {
        interactionNotification.SetActive(true);
    }
    public void DeNotifyPlayer()
    {
        interactionNotification.SetActive(false);
    }
}
