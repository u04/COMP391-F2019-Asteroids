using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSaucer : MonoBehaviour
{
    public GameObject lazerPrefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * 5f;
        
    }
    void Shoot()
    {
        Instantiate(lazerPrefab, firePoint.position, Random.rotation);
    }

}
