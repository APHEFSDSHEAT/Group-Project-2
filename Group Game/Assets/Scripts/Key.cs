using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool isOpen;
    //public Animator animator;


    public void GetKey()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("GetKey()");
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
