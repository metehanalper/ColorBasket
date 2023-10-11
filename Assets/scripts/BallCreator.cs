using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCreator : MonoBehaviour
{
    public static int score =0;
    public static int life =3;
    public GameObject[] coinPrefab;
    
    public float spawnTime = 20f;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(coinPrefab[Random.Range(0,6)], new Vector2(Random.Range(-3f, 3f), 6), transform.rotation);
            timer = spawnTime;

        }
    }
    
}
