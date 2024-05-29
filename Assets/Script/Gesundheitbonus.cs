using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gesundheitbonus : MonoBehaviour
{
    private LifeManagment lifeManagment;
    [SerializeField] private GameObject PlusInstanz;
    //[SerializeField] private GameObject PlusInstanz;
    //[SerializeField] private GameObject[] spawnPointsPlus;

    // Start is called before the first frame update
    //public int plusAnzahl;
    public PlusErstellen plusErstellenScript;
    void Start()
    {
        lifeManagment = GameObject.Find("FPSController").GetComponent<LifeManagment>();
        //PlusInstanz.SetActive(true);
        //plusAnzahl = 5;
    }

    // Update is called once per frame
  
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            lifeManagment.currentHealth = lifeManagment.currentHealth + 1;
            //plusAnzahl = plusAnzahl + 1;
            plusErstellenScript.WartenPlus();
            PlusInstanz.SetActive(false);
            //Debug.Log(plusAnzahl);
        }
    }
    /*public IEnumerator SpawnGesundheitsBonus()
    {
        yield return new WaitForSeconds(180);
        PlusInstanz.SetActive(true);
    } */
}