using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "sq")
        {
            //Debug.Log("collision detected!");
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "la")
        {
            Destroy(gameObject);
        }
    }
}
