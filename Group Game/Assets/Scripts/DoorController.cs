using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    // TUTORIAL USED: https://www.youtube.com/watch?v=cLzG1HDcM4s THIS TUT HELPED CREATE PICK-UP-ABLE KEYS AND DOOR UNLOCK

    public bool isOpen;
    //public Animator animator;
    public AudioClip soundEffect;

    public void OpenDoor(GameObject obj)
    {
        if (!isOpen)
        {
            PlayerKeyManaging manager = obj.GetComponent<PlayerKeyManaging>();
            if (manager)
            {
                if (manager.keyCount > 0)
                {
                    isOpen = true;
                    manager.UseKey();
                    //animator.SetBool("IsOpen", isOpen);
                    //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                    Debug.Log("Door is unlocked");
                }
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }

}
