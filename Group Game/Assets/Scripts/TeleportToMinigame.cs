using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToMinigame : MonoBehaviour //TELEPORTS PLAYER TO DESIGNATED AREA (inspector)
{
    [Header("assignable things")]
    public GameObject playerTest;
    public AudioClip soundEffect;
    //public Animator animator;

    [Header("bools")]
    public bool isOpen;

    [Header("variables")] 
    public Vector3 minigamePosition; //16.6f, -3.94f, -2f

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TeleportThePlayer()
    {
        if (isOpen == true)
        {
            playerTest.transform.position = minigamePosition; //new Vector3(1000f, -3.62f, -2f);
            Debug.Log("teleport");
        }
    }

    public void OpenDoor(GameObject obj)
    {
        if (!isOpen)
        {
            PlayerKeyManaging manager = obj.GetComponent<PlayerKeyManaging>();
            if (manager)
            {
                if (manager.keyCount >= 0)
                {
               
                    isOpen = true;
                    //manager.UseKey();
                    //animator.SetBool("IsOpen", isOpen);
                    AudioManager.instance.PlayClip(soundEffect);
                    Debug.Log("TeleportDoor is unlocked");
                    TeleportThePlayer();
                    isOpen = false;

                }
            }
        }
        

    }

}
