using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyObjekt;
    [SerializeField] private float spawnTime = 4f;
    [SerializeField] private float spawnTimeMax = 10f;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private Material enemyMaterial;
    [Header("Enemy Levels")]
    [SerializeField] private int[] killScores;
    [SerializeField] private int[] startHealthValues;
    [SerializeField] private Material[] enemyMaterials;
    [SerializeField] private int enemysCount;
    //[SerializeField] private GameObject shootableObjekt;
    private int startIndex = 0;

    private Vector3 spawnPosition;
    private bool waitActive;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitActive)
        {
            StartCoroutine(RandomWait());
        }
    }

    private void Spawn()
    {
        enemysCount += 1;
        int index = Random.Range(startIndex, 4);
        spawnPosition = spawnPoints[index].transform.position;
        GameObject spawnEnemy = Instantiate(enemyObjekt, spawnPosition, Quaternion.identity);
        //ShootableBox shootableBox = spawnEnemy.GetComponent<ShootableBox>();
        //shootableBox.killScore = 1;
        //shootableBox.currentHealth = 3;
        //spawnEnemy.GetComponent<MeshRenderer>().material = enemyMaterial;

        /*Shoot shootScript = spawnEnemy.GetComponent<Shoot>();
        shootScript.killScore = 10;
        shootScript.currentHealth = 30;*/

        if (enemysCount >= 3)
        {
            spawnTime = 10;
        }
        else if (enemysCount >= 7)
        {
            spawnTime = 6;
        }
        else if (enemysCount >= 15)
        {
            spawnTime = 5;
        }
        else if (enemysCount >= 30)
        {
            spawnTime = 4;
        }
        else if (enemysCount >= 50)
        {
            spawnTime = 2;
        }

    }
    private IEnumerator RandomWait()
    {
        waitActive = true;
        yield return new WaitForSeconds(spawnTime);
        Spawn();
        waitActive = false;
    }

    public void SpawnPointDelete()
    {
        startIndex = 1;
        spawnPoints.RemoveAt(0);
    }
}
