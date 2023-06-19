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
    [SerializeField] int requiredKeys;
    [SerializeField] float timeUntillTeleport = 1.5f;

    public void OpenDoor(GameObject obj)
    {
        if (!isOpen)
        {
            PlayerKeyManaging manager = obj.GetComponent<PlayerKeyManaging>();
            if (manager)
            {
                if (manager.keyCount >= requiredKeys)
                {
                    isOpen = true;
                    manager.UseKey();
                    //animator.SetBool("IsOpen", isOpen);
                    AudioManager.instance.PlayClip(soundEffect);
                    Debug.Log("Door is unlocked");
                    StartCoroutine(Teleport());
                }
            }
        }
        /*else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }*/
       
    }
    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(timeUntillTeleport);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
