using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // THIS SCRIPT HANDLES ALL THINGS RELATED TO THE HIDING CLOSET

    [Header("Bools")]
    [SerializeField] public bool nearCloset = false;
    [SerializeField] public bool inCloset;

    [Header("Variables")]
    [SerializeField] Vector3 closetAnimationPosition;
    //[SerializeField] Vector3 infoPosition;
    [SerializeField] float timeBeforeGettingIn;

    [Header("Sound")]
    [SerializeField] AudioClip getInClosetSFX;

    [Header("GameObjects")]
    [SerializeField] GameObject closet;
    //[SerializeField] GameObject getOutInfo;
    public GameObject closetInteractionNotification;




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
            NotifyPlayer();
        }


    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            nearCloset = false;
            Debug.Log("nearCloset was turned false");
            DeNotifyPlayer();
        }

    }

    public void GetInCloset()
    {
        if (Input.GetKeyDown("e") && nearCloset == true && inCloset == false)
        {
            AudioManager.instance.PlayClip(getInClosetSFX);
            StartCoroutine(waitNow());
        }
       
    }

    IEnumerator waitNow()
    {
        yield return new WaitForSeconds(timeBeforeGettingIn);
        inCloset = true;
        yield return new WaitForSeconds(0.2f);
        Debug.Log("e was pressed");
        GameObject closetThing = Instantiate(closet, closetAnimationPosition, transform.rotation);

        //GameObject getOut = Instantiate(getOutInfo, infoPosition, transform.rotation);

    }


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
    public bool GetClosetBool()
    {
        return inCloset;
    }

    public bool NearClosetBool()
    {
        return nearCloset;
    }
}
