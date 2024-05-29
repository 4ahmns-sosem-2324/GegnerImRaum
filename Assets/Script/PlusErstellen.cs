using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusErstellen : MonoBehaviour
{
    public Gesundheitbonus erstellen;

    [SerializeField] private GameObject PlusInstanz;
    [SerializeField] private GameObject PlusInstanz1;
    [SerializeField] private GameObject PlusInstanz2;
    [SerializeField] private GameObject PlusInstanz3;
    [SerializeField] private GameObject PlusInstanz4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /*void Update()
    {
        if (erstellen.plusAnzahl <= 0)
        {
            StartCoroutine(SpawnGesundheitsBonus());
        }
    }*/
    public void WartenPlus()
    {
        StartCoroutine(SpawnGesundheitsBonus());
        
    }

    public IEnumerator SpawnGesundheitsBonus()
    {
        
        yield return new WaitForSeconds(180);
        PlusInstanz.SetActive(true);
        PlusInstanz1.SetActive(true);
        PlusInstanz2.SetActive(true);
        PlusInstanz3.SetActive(true);
        PlusInstanz4.SetActive(true);
        //erstellen.plusAnzahl = 5;
    }
}
