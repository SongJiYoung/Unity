using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        float randomx = Random.Range(-23.0f, 23.0f);
        if (collision.tag == "Ground" || collision.tag == "Character")
        {
            Destroy(gameObject);
            Debug.Log("부딪힘");
        }
    }
}
