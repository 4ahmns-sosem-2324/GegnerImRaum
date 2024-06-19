using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionsManagement : MonoBehaviour
{
    public int munition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        munition = PlayerPrefs.GetInt("munition");
                         
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (munition < 10)
            {
                munition++;
                PlayerPrefs.SetInt("munition", munition);
                Debug.Log("Munition gesendet");
            }
        }
    }
}
