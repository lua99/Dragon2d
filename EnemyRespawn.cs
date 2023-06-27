using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyRespawnPoint;
    


    void Start()
    {
        StartCoroutine(RespawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RespawnEnemy()
    {
        while (true)
        {
            float waitTime = Random.Range(2f, 4f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(enemy, enemyRespawnPoint.position, enemyRespawnPoint.rotation*Quaternion.Euler(0f,180f,0f));
        }
    }

    
  
    
}
