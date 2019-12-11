using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //public AudioClip m_AudioClip;
    //AudioSource m_AudioSource;
    public int score;
    public static int counter = 0;
    public static int counterOther = 0;

    public GameObject apple;      // Apple Object in Scene (Sprite)
    public GameObject badApple;      // Bad Apple Object in Scene (Sprite)

    public float spawnTime = 2f;            // How long between each spawn.
    public float fallSpeed = 40.0f;    //The speed of falling Apples

    private float timer = 0; //counting timer, reset after calling SpawnRandom() function
    private int randomNumber;       //variable for storage of an random Number
    public Transform saucerSpawn;
    public GameObject saucer;
    void Start()
    {
        //m_AudioSource.clip = m_AudioClip;
        ////Fetch the AudioSource component of the GameObject (make sure there is one in the Inspector)
        //m_AudioSource = GetComponent<AudioSource>();
        ////Stop the Audio playing
        //m_AudioSource.loop = true;
        //m_AudioSource.Play();
        InvokeRepeating("Saucer", 60, 60f);
    }
    void Update()
    {
        

        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime)
        {
            SpawnRandom();       //Calling method SpawnRandom()
            timer = 0;        //Reseting timer to 0
        }
        enemyCount = GameObject.FindGameObjectsWithTag("la").Length;
        

    }

    int maxEnemy = 3;
    int enemyCount;
    public void SpawnRandom()
    {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));

        if (enemyCount >= maxEnemy) return;
        Instantiate(apple,
                new Vector3(Random.Range(-9.0f, 9.0f),
                    Random.Range(-6.0f, 6.0f), 0),
                Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
        

    }
    void Saucer()
    {
        Instantiate(saucer, saucerSpawn.position, saucerSpawn.rotation);
    }

}