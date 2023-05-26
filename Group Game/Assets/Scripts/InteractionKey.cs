using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionKey : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;





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
            collision.gameObject.GetComponent<PlayerKeyManaging>().NotifyPlayer();
            Debug.Log("Player is now IN range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            isInRange = false;
            collision.gameObject.GetComponent<PlayerKeyManaging>().DeNotifyPlayer();
            Debug.Log("Player is now NOT in range");
        }
    } 
}
