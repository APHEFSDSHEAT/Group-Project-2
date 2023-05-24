using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    int timesHit;
    [SerializeField] Sprite[] blockHitSprites;
    public object ShowNextHitSprite { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            timesHit++;
            int maxHits = blockHitSprites.Length + 1;
            if (timesHit >= maxHits)
            {
                DestroyBlock();
            }
            else
            {
                showNextHitSprite();
            }
        }

    }

    private void showNextHitSprite()
    {
        int spriteIndex = timesHit - 1;
        GetComponent<SpriteRenderer>().sprite = blockHitSprites[spriteIndex];
    }


    private void DestroyBlock()
    {
        Destroy(gameObject);
    }
}
