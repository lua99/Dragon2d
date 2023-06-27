using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 jumpForce;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jumpForce);
        }

        if (transform.position.y > 5.7)
        {
            SceneManager.LoadScene(0);
        }

        else if (transform.position.y < -5.7)
        {
            SceneManager.LoadScene(0);
        }

        



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            SceneManager.LoadScene(0);
        }
    }
}
    