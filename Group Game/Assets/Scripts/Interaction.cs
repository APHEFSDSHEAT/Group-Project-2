using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [Header("bools")]
    [SerializeField] public bool nearCloset;

    [Header("sound")]
    [SerializeField] AudioClip getInClosetSFX;

    void Start()
    {
        
    }

    void Update()
    {
        GetInCloset();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            nearCloset = true;
        }
        
    }

    public void GetInCloset()
    {
        if (Input.GetKeyDown("e") && nearCloset == true)
        {
            Debug.Log("e was pressed");
            //AudioManager.instance.PlayClip(getInClosetSFX);
        }
        
            
        
    }

}
