using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{
    Interaction interaction;


    public void GetOutOfCloset()
    {
        if (Input.GetKeyDown("e") && interaction.inCloset == true)
        {
            Destroy(gameObject);
            interaction.inCloset = false;
        }
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
