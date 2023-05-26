using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyManaging : MonoBehaviour
{
    public int keyCount;
    private GameObject interactionNotification;


    public void PickupKey()
    {
        keyCount++;
        Debug.Log("Picked up key");
    }
    public void UseKey()
    {
        keyCount--;
        Debug.Log("USed a key");
    }

    public void NotifyPlayer()
    {
        interactionNotification.SetActive(true);
    }
    public void DeNotifyPlayer()
    {
        interactionNotification.SetActive(false);
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
