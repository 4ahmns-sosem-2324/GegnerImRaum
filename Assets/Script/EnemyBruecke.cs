using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBruecke : MonoBehaviour
{
    [SerializeField] private GameObject Bruecke;
    //[SerializeField] private GameObject Stiege;
    [SerializeField] private GameObject Brett;
    //[SerializeField] private GameObject einBrett;
    [SerializeField] private DestroyBrett brettZerstoeren;
    // Start is called before the first frame update
    void Start()
    {
        //Bruecke.GetComponent<MeshRenderer>().enabled = true;
        Bruecke.SetActive(false);
        //Stiege.SetActive(false);
        //Brett.SetActive(true);
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Bruecke.GetComponent<MeshRenderer>().enabled = true;
            Bruecke.SetActive(true);
            //Stiege.SetActive(true);
            Brett.SetActive(false);
            //StartCoroutine(ErstellenBrett());
        }
    }
    /*public IEnumerator ErstellenBrett()
    {
        //brettZerstoeren.Zerstoeren();
        yield return new WaitForSeconds(5);
        Brett.SetActive(true);
        Destroy(Brett);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Bruecke.GetComponent<MeshRenderer>().enabled = true;
            
            //Bruecke.SetActive(false);
            //Stiege.SetActive(true);
            //Instantiate(Brett);
            //Debug.Log("instatiate");
            //Brett.SetActive(true);
            brettZerstoeren.Zerstoeren();
            Destroy(Brett);
        }
    }*/
}
