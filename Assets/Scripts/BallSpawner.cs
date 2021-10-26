using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using Tabtale.TTPlugins;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPrefabs = new GameObject[4];
    

    [SerializeField] private Transform[] locations = new Transform[3];

    [SerializeField] private Transform newSpawned;

    public float waitBeforeSpawn = 2;

    public bool canSpawn = true;
    
    private void Awake()
    {
        TTPCore.Setup();
    }
    private void Start()
    {
        spawnABall();
    }

    private void Update()
    {
    }

    public void spawnABall()
    {
        StopAllCoroutines();
        StartCoroutine(SpawnPrefabs());
    }
    
    private IEnumerator SpawnPrefabs()
    {
        yield return new WaitForSeconds(1f);
        var spawned = Instantiate(ballPrefabs[RandomPrefab()], locations[0].position,
                Quaternion.Euler(0, 90, 0));
        spawned.gameObject.transform.parent = newSpawned;
    }

    
    private IEnumerator SpawnPrefabs1()
    {
        while (true)
        {
            yield return new WaitForSeconds(RandomSecond());
            Instantiate(ballPrefabs[RandomPrefab()], locations[1].position, Quaternion.Euler(0, 90, 0));
        }
    }
    
    private IEnumerator SpawnPrefabs2()
    {
        while (true)
        {
            yield return new WaitForSeconds(RandomSecond());
            Instantiate(ballPrefabs[RandomPrefab()], locations[2].position, Quaternion.Euler(0, 90, 0));
        }
    }


    private int RandomPrefab()
    {
        return (Random.Range(0,3));
    }

    private int RandomSecond()
    {
        return (Random.Range(1,5));
    }



}
