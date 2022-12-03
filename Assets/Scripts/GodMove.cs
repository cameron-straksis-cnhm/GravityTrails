using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMove : MonoBehaviour
{

    //public float speed;
    //private int fly;
    public Rigidbody2D avatarRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //speed = 5f;
        //fly = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //float vertical = Input.GetAxis("Vertical");
        //Vector3 flight = new Vector3(0, vertical);
        //if (Input.GetButtonDown("Vertical") && fly == 1)
        //{
            //transform.position += flight * Time.deltaTime * speed;
        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Power")
        {
            avatarRigidbody.gravityScale *= 0;
            Destroy(collision.gameObject);
        }
    }
}
