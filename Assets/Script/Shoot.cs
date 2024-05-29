using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int currentHealth = 3;
    public int killScore = 1;
    public SpawnEnemy enemySpawnScript;

    private ScoreManagment scoreManagment;
    [SerializeField] private GameObject spawnPoints1;
    //private Shoot shootScript;

    private void Start()
    {
        scoreManagment = GameObject.Find("ScoreManager").GetComponent<ScoreManagment>();
        //shootScript = GameObject.Find("ShootCube").GetComponent<Shoot>();
    }
    public void Damage(int damageAmmount)
    {
        currentHealth -= damageAmmount;

        if (currentHealth <= 0)
        {
            Destruction();
            //shootScript.Destruct();
        }
    }

    public void Destruction()
    {
        scoreManagment.currentScore += killScore;
        Destroy(gameObject, 0);
        Destroy(spawnPoints1);
        enemySpawnScript.SpawnPointDelete();
        spawnPoints1.SetActive(false);
    }

    /*public SpawnEnemy enemySpawnScript;
    [SerializeField] private GameObject spawnPoints1;

    private void Start()
    {
        
    }
    public void Destruct()
    {
        Debug.Log("Destruct");
        spawnPoints1.SetActive(false);
        //Destroy(spawnPoints1);
        enemySpawnScript.SpawnPointDelete();
    }*/
}
