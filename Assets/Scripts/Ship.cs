using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    public Transform firePoint;
    public Transform tail;
    public GameObject lazerPrefab;
    public GameObject tailObject;
    Rigidbody rb;
    public float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    void Update()
    {
        //Move();
        if (Input.GetKey("d"))
        {
            RotateLeft();
        }
        if (Input.GetKey("a"))
        {
            RotateRight();
        }
        if (Input.GetKey("w"))
        {
            //Foward();
            //Instantiate(tailObject, tail.position, tail.rotation);
            tailObject.SetActive(true);
            tailObject.transform.parent = transform;



        }
        if (!Input.GetKey("w"))
        {
            tailObject.SetActive(false);
        }

            //if (Input.GetKey("s"))
            //{
            //    Back();
            //}
            if (Input.GetKey("space"))
        {
            Shoot();
        }

        //// Rotate the ship if necessary
        //transform.Rotate(0, 0, -Input.GetAxis("Horizontal") *
        //    0.02f * Time.deltaTime);

        // Thrust the ship if necessary
        GetComponent<Rigidbody2D>().AddForce(transform.up * 0.002f * Input.GetAxis("Vertical"));

    }
    //float speed = 7.0f;
    void RotateLeft()
    {
        transform.Rotate(transform.forward * -5);
    }
    void RotateRight()
    {
        transform.Rotate(transform.forward * 5);
    }
    void Foward()
    {
        transform.position += transform.up * Time.deltaTime * 5f;
        //rb.AddForce(transform.forward * thrust);
    }
    void Back()
    {
        transform.position += transform.up * Time.deltaTime * -5f;
    }
    void Shoot()
    {
        Instantiate(lazerPrefab, firePoint.position, firePoint.rotation);
    }
    
    
}
