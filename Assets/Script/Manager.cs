using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private int plattForm;

    bool isFalling;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plattForm >= 1)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if (isFalling)
        {
            Destroy(gameObject, 4);
        }
    }
    
    

    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
                
            plattForm += plattForm;
            isFalling = true;
            
        }
    }
    /*public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Plattform")
        {
            platte.GetComponent<Rigidbody>().useGravity = false;
        }
    }*/
}
