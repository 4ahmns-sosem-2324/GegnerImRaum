using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
public class Pistol : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float bulletSpeed = 20f;
    public int munition = 10;
    public bool triggerValue;

  
    private XRController leftController;
    private XRController rightController;
    public void FireBullet()
    {
        //--- Instantiate a bullet and fire it forward
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>()
            .AddForce(spawnPoint.forward * bulletSpeed, ForceMode.Impulse);
        
        //--- Destroy the bullet after 5 seconds
        Destroy(spawnedBullet, 5);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("munition", munition);
        if (munition > 0)
        {
            if (rightController != null)
            {
                // Überprüfen und auslesen des Trigger-Werts des rechten Controllers
                if (rightController.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float rightTriggerValue))
                {
                    Debug.Log("Right Trigger Value: " + rightTriggerValue);

                    FireBullet();
                    munition--;
                }
            }
          
                
            
          
            
        }
       
    }

    private void Start()
    {
        leftController = GameObject.Find("LeftHand Controller").GetComponent<XRController>();
        rightController = GameObject.Find("RightHand Controller").GetComponent<XRController>();
    }

}