using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyCounter : MonoBehaviour
{
    TextMeshProUGUI keyCounterText;
    PlayerKeyManaging playerKeyManagingScript;
    // Start is called before the first frame update
    void Start()
    {
        keyCounterText = GetComponent<TextMeshProUGUI>();
        playerKeyManagingScript = FindObjectOfType<PlayerKeyManaging>();
    }

    // Update is called once per frame
    void Update()
    {
        keyCounterText.text = playerKeyManagingScript.GetKeyCount().ToString();
    }

    public void UpdateText()
    {
        

    }
}
