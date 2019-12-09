using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleTwo : MonoBehaviour
{
    private Rigidbody2D rb2D;
    //private float thrust = 10.0f;

    public Text scoreText;
    //public int score;
    Text g;
    public GameObject smallThing;

    void Start()
    {
        g = GameObject.FindGameObjectWithTag("Text").GetComponent<Text>();
    }

    void Update()
    {
        Vector3 position = this.transform.position;
        transform.position += Vector3.left * 3.5f * Time.deltaTime;


        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
        else if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
        else if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, -6, 0);
        }
        else if (transform.position.y < -6)
        {
            transform.position = new Vector3(transform.position.x, 6, 0);
        }
        
    }
    //int counter = 0;
    GameObject ted;
    Rigidbody2D sam;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Spawn.counter++;
            Debug.Log(Spawn.counter);
            g.text = "Count: " + Spawn.counter.ToString();
            
        }

        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            
            ted = Instantiate(smallThing, transform.position, transform.rotation);
            //ted.AddComponent<Rigidbody2D>();
            sam = ted.GetComponent<Rigidbody2D>();
            sam.AddForce(transform.forward * 1.2f);

        }

    }
}
