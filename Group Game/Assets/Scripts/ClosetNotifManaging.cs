using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetNotifManaging : MonoBehaviour
{
    public GameObject closetInteractionNotification;

    public void NotifyPlayer()
    {
        closetInteractionNotification.SetActive(true);

    }
    public void DeNotifyPlayer()
    {
        closetInteractionNotification.SetActive(false);

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
