using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{

    public float bulletSpeed;
    Rigidbody2D rb;



    private void Awake()
    {
        Destroy(gameObject, 2f);
    }

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            Destroy(gameObject);
        }
    }


}
