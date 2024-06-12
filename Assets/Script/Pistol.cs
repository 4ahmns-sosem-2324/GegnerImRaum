using UnityEngine;

public class Pistol : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float bulletSpeed = 20f;
    public int munition = 10;

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
            if (Input.GetMouseButtonDown(0))
            {
                FireBullet();
                munition--;
            }
        }
       
    }
}