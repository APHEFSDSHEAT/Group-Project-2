using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetNotifManaging : MonoBehaviour
{
    // THIS SCRIPT IS WHAT MAKES THE NOTIFICATION POPUP FOR WHEN THE PLAYER IS NEAR THE CLOSET

    // REVISION - THIS SCRIPT IS NOT USED ANYMORE !!!! see "Interaction" script for the same features

    public GameObject closetInteractionNotification;

    public void NotifyPlayer()
    {
            closetInteractionNotification.SetActive(true);
            Debug.Log("notified player");
        
    }
    public void DeNotifyPlayer()
    {
        closetInteractionNotification.SetActive(false);
        Debug.Log("DEnotified player");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
