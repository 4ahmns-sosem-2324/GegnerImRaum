using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bretterstellen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Brett;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnBrett());
    }
    public IEnumerator SpawnBrett()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("Hallo");
       //GameObject BrettNeu = Instantiate(Brett, new Vector3(-16.25f, 0, -8.749999f);
    }
}
