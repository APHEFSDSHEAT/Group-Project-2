using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameDeath : MonoBehaviour
{
    [Header("assignable things")]
    public GameObject player;
    public AudioClip soundEffect;
    public GameObject jumpscare;


    [Header("variables")]
    public Vector3 position;
    [SerializeField] float waitingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = position;
        //NotifyPlayer();
        //StartCoroutine(wait());
    }

    public void NotifyPlayer()
    {
        jumpscare.SetActive(true);
        

    }
    public void DeNotifyPlayer()
    {
        jumpscare.SetActive(false);
        

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(waitingTime);
        DeNotifyPlayer();
    }
}
