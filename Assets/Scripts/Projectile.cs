using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }

    // Update is called once per frame
    void Update()
    {
         transform.position += direction.offset * Time.deltaTime * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Invoke("DestroyThrowable", 0);
        }

        if (collision.gameObject.tag == "Ground")
        {
            Invoke("DestroyThrowable", 0);


        }

        if (collision.gameObject.tag == "Shortcut")
        {
            Invoke("DestroyThrowable", 0);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "unkillable")
        {
            Invoke("DestroyThrowable", 0);
        }

    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }

}


