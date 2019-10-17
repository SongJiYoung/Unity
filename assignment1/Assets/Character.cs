using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int life = 3;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector2(-6.0f * Time.deltaTime, 0.0f));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector2(6.0f * Time.deltaTime, 0.0f));
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mace")
        {
            if (life == 3)
            {
                Destroy(GameObject.Find("Life3"));
                life = life - 1;
            }

            else if (life == 2)
            {
                Destroy(GameObject.Find("Life2"));
                life = life - 1;
            }

            else if (life == 1)
            {
                Destroy(GameObject.Find("Life1"));
                life = life - 1;
            }

            else
            {
                Debug.Log("game over");
                gameover.SetActive(true);
            }

        }
    }
}
