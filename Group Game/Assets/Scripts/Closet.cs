using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{
    // THIS SCRIPT HANDLES GETTING OUT OF THE HIDING CLOSET (destruction of GameObject)

    Interaction interaction;
    [SerializeField] AudioClip getOutClosetSFX;
    [SerializeField] float timeBeforeGettingOut;


    public void GetOutOfCloset()
    {
        if (Input.GetKeyDown("e"))
        {
            AudioManager.instance.PlayClip(getOutClosetSFX);
            StartCoroutine(waitAgain());
            

        }
    }

    IEnumerator waitAgain()
    {
        interaction.inCloset = false;
        yield return new WaitForSeconds(timeBeforeGettingOut);
        Debug.Log("destroyed");
        Destroy(gameObject);

    }


    // Start is called before the first frame update
    void Start()
    {
        interaction = FindObjectOfType<Interaction>();
    }

    // Update is called once per frame
    void Update()
    {
        GetOutOfCloset();
    }
}
