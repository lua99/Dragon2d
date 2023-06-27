using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RespawnObstacle()); 
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    IEnumerator RespawnObstacle()
    {
        while (true)
        {
            float waitTime = Random.Range(2f, 4f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);

        }
    }

    
  



    
}
