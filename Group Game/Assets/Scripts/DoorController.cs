using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // TUTORIAL USED: https://www.youtube.com/watch?v=cLzG1HDcM4s LEFT OFF 9:08

    public bool isOpen;

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
                    manager.PickupKey();
                }
            }
        }
       
    }

}
