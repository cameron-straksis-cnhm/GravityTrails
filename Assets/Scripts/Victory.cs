using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public int Dorito;
    public GameObject Portal;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Dorito = GameObject.FindGameObjectsWithTag("Vilian").Length;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (Dorito == 0)
        {
            Portal.SetActive(true);
        }

        if (Dorito == 1)
        {
            Portal.SetActive(false);
        }

        if (enemyCount > 0)
        {
            Portal.SetActive(false);
        }

        if (enemyCount == 0)
        {
            Portal.SetActive(true);
        }

    }
}
