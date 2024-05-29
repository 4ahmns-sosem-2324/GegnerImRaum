using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotable : MonoBehaviour
{
    public int currentHealth = 1;
    public int killScore = 1;
    public SpawnEnemy enemySpawnScript;

    private ScoreManagment scoreManagment;
    //private ShootableBox shootableBoxScript;
    private GameObject spawnPoints1;

    private void Start()
    {
        scoreManagment = GameObject.Find("ScoreManager").GetComponent<ScoreManagment>();
        //shootableBoxScript = GameObject.Find("ShootCube").GetComponent<ShootableBox>();
        spawnPoints1 = GameObject.Find("Spawn0");
        //enemySpawnScript = GameObject.Find("SpawnEnemies").GetComponent<SpawnEnemy>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destruction();
        }
    }
    /*public void Damage(int damageAmmount)
    {
        currentHealth -= damageAmmount;

        if (currentHealth <= 0)
        {

            Destruction();
        }
    }*/

    private void Destruction()
    {
        scoreManagment.currentScore += killScore;
        Destroy(gameObject, 0);
        
    }

}
