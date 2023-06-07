using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{
    // THIS SCRIPT HANDLES GETTING OUT OF THE HIDING CLOSET (destruction of GameObject)

    Interaction interaction;


    public void GetOutOfCloset()
    {
        if (Input.GetKeyDown("e"))
        {
            
            StartCoroutine(waitAgain());
            interaction.inCloset = false;

        }
    }

    IEnumerator waitAgain()
    {
        yield return new WaitForSeconds(0.2f);
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
