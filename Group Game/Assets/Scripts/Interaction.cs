using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [Header("Bools")]
    [SerializeField] public bool nearCloset = false;
    [SerializeField] public bool inCloset;

    [Header("Variables")]
    [SerializeField] Vector3 closetAnimationPosition;

    [Header("Sound")]
    [SerializeField] AudioClip getInClosetSFX;

    [Header("GameObjects")]
    [SerializeField] GameObject closet;


    void Start()
    {
        
    }

    void Update()
    {
        GetInCloset();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" /*&& nearCloset == false*/)
        {
            nearCloset = true;
            Debug.Log("nearCloset was turned true");
        }

        if (collision.gameObject.CompareTag("player")) // NOTIFICATION
        {  
            collision.gameObject.GetComponent<ClosetNotifManaging>().NotifyPlayer();
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            nearCloset = false;
            Debug.Log("nearCloset was turned false");
        }

        if (collision.gameObject.CompareTag("player"))
        {
            collision.gameObject.GetComponent<ClosetNotifManaging>().DeNotifyPlayer();
        }
    }


    public void GetInCloset()
    {
        if (Input.GetKeyDown("e") && nearCloset == true && inCloset == false)
        {
            Debug.Log("e was pressed");
            GameObject closetThing = Instantiate(closet, closetAnimationPosition, transform.rotation);
            inCloset = true;
            //AudioManager.instance.PlayClip(getInClosetSFX);
        }
        
            
        
    }

    public bool GetClosetBool()
    {
        return inCloset;
    }

    public bool NearClosetBool()
    {
        return nearCloset;
    }

}
