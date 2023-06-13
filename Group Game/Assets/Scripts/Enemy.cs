using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySpawning enemySpawning;
    [SerializeField] int health = 3;
    [SerializeField] float deathTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Die();
        enemySpawning = FindObjectOfType<EnemySpawning>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer otherDamageDealer = other.gameObject.GetComponent<DamageDealer>();
        if (!otherDamageDealer) { return; }
        ProcessHit(otherDamageDealer);
    }

    private void ProcessHit(DamageDealer otherDamageDealer)
    {
        health -= otherDamageDealer.GetDamage();
        otherDamageDealer.Hit();
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject, deathTime);
    }
}
