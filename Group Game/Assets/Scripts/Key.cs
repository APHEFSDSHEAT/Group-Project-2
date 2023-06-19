using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour // THIS SCRIPT IS ON THE KEY ITSELF - SELF EXPLANATORY
{
    public bool isOpen;
    [SerializeField] AudioClip soundEffect;
    //public Animator animator;


    public void GetKey()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("GetKey()");
            AudioManager.instance.PlayClip(soundEffect);
            //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            Destroy(gameObject);
            //animator.SetBool("IsOpen", isOpen);
        }
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
