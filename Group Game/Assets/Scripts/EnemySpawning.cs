using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;
    public bool canSpawnEnemy = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("player"))
        {
            if (canSpawnEnemy == true)
            {
                
                EnemySpawner();
            }
        }
    }

    void EnemySpawner()
    {
        Instantiate(enemy, enemyPos.position, enemyPos.rotation);
        canSpawnEnemy = false;
    }

    
    public void SpawnAnotherEnemy(float waitTime)
    {
        StartCoroutine(MakeEnemySpawnable(waitTime));
    }

    public IEnumerator MakeEnemySpawnable(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        canSpawnEnemy = true;
    }
}
