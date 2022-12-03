using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    //Dorito Avatar;
    //Avatar.GetComponent<Throwable>();
    //Avatar.GetComponent<Throwable>().throwableCounter;
    //Throwable.throwableCounter();

    private float repos;
    //public GameObject shuriken;
    Throwable Throwable;
    [SerializeField] GameObject Avatar;
    
    // Start is called before the first frame update
    void Start()
    {
        Throwable = Avatar.GetComponent<Throwable>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        repos = Random.Range(-3.7f, 8.5f);


        if (transform.position.x <= -26)
        {
            transform.position = new Vector3(26, repos, transform.position.z);
            Throwable.throwableCounter++;

        }





    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ThrowingObject")
        {
            transform.position = new Vector3(28, repos, transform.position.z);
        }

    }

    //private void Ammo()
    //{
        //FindObjectOfType<Avatar>)().Addthrowablecounter(1);
    //}
}
