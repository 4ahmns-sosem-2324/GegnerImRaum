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

    private InputDevice leftController;
    private InputDevice rightController;

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
            if (rightController.isValid)
            {
                float triggerValue;
                if (rightController.TryGetFeatureValue(CommonUsages.trigger, out triggerValue))
                {
                    Debug.Log("Right Trigger Value: " + triggerValue);
                    FireBullet();
                    munition--;
                }
            }
          
            
        }
       
    }

    private void Start()
    {
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, inputDevices);
        if (inputDevices.Count > 0)
        {
            leftController = inputDevices[0];
        }

        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, inputDevices);
        if (inputDevices.Count > 0)
        {
            rightController = inputDevices[0];
        }
    }
}