using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyManaging : MonoBehaviour
{
    // SELF EXPLANATORY - ALL THINGS RELATED TO THE KEY

    [SerializeField] public int keyCount;
    //public GameObject interactionNotification;


    public void PickupKey()
    {
        keyCount++;
        //Debug.Log("KeyCount++");
    }
    public void UseKey()
    {
        keyCount--;
        //Debug.Log("KeyCount--");
    }

    public int GetKeyCount()
    {
        Debug.Log("returned keycount");
        return keyCount;
        
    }

    /*public void NotifyPlayer()
    {
        interactionNotification.SetActive(true);
    }
    public void DeNotifyPlayer()
    {
        interactionNotification.SetActive(false);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
