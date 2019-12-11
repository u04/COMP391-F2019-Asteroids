﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship2 : MonoBehaviour
{
    public Transform firePoint;
    public Transform tail;
    public GameObject lazerPrefab;
    public GameObject tailObject;
    public GameObject explo;
    Rigidbody rb;
    public float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        explo.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        //Move();
        if (Input.GetKey("l"))
        {
            RotateLeft();
        }
        if (Input.GetKey("j"))
        {
            RotateRight();
        }
        if (Input.GetKey("i"))
        {
            //Foward();
            //Instantiate(tailObject, tail.position, tail.rotation);
            tailObject.SetActive(true);
            tailObject.transform.parent = transform;



        }
        if (!Input.GetKey("i"))
        {
            tailObject.SetActive(false);
        }

        //if (Input.GetKey("k"))
        //{
        //    Back();
        //}
        if (Input.GetKey("u"))
        {
            Shoot();
        }

        //// Rotate the ship if necessary
        //transform.Rotate(0, 0, -Input.GetAxis("Horizontal") *
        //    0.02f * Time.deltaTime);

        // Thrust the ship if necessary
        GetComponent<Rigidbody2D>().AddForce(transform.up * 0.002f * Input.GetAxis("Vertical2"));

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
    Vector3 temp = new Vector3(0f, 0f, 0);
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "la" || collision.gameObject.tag == "Small Asteroid" || collision.gameObject.tag == "Bullet")
        {

            explo.SetActive(true);


            explo.SetActive(false);

            this.gameObject.transform.position = temp;
            //Destroy(this.gameObject);

        }

    }


}