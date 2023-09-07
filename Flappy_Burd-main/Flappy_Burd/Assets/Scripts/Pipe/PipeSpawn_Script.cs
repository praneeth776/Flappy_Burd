using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn_Script : MonoBehaviour
{
    public GameObject Pipe;
    public GameObject Coin;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipeAndCoin();
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipeAndCoin();
            timer = 0;
        }
        
    }

    void SpawnPipeAndCoin()
    {
        float randomRange = RandomRange();
        float randomCoinGen = Random.Range(0, 6);

        Instantiate(Pipe, new Vector3(transform.position.x, randomRange,0), transform.rotation);

        if (randomCoinGen <= 2)
        {
            Instantiate(Coin, new Vector3(transform.position.x, randomRange, 0), transform.rotation);
        }
    }

    float RandomRange()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        return Random.Range(lowestPoint, highestPoint);
    }

}
