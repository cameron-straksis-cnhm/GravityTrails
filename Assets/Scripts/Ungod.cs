using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ungod : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ungod")
        {
           avatarRigidbody.gravityScale = 1;
           Destroy(collision.gameObject);
        }
    }
}
