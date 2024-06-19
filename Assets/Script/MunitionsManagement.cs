using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionsManagement : MonoBehaviour
{
    public int munition;
    public int munition02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        munition = PlayerPrefs.GetInt("munition");
        if (Input.GetMouseButtonDown(0))
        {
            munition--;
            PlayerPrefs.SetInt("munition", munition);
        }
                         
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (munition < 10)
            {
                munition02 = munition;
                munition02++;
                PlayerPrefs.SetInt("munition", munition02);
                Debug.Log("Munition gesendet");
            }
        }
    }
}
