using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    public GameObject Rock;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Makemace", 1, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Makemace()
    {
        float randomx= Random.Range(-20.0f, 20.0f);
        if (true)
        {
            GameObject mace = (GameObject)Instantiate(Rock, new Vector2(randomx, 6.0f), Quaternion.identity);
        }
    }

}
