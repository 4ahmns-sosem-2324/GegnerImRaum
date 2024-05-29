using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManagment : MonoBehaviour
{
    [Header("Health Values")]
    public int currentHealth = 10;
    [SerializeField] private bool alive = true;
    [Header("FPS Objedts")]
    [SerializeField] private GameObject fpsCamera;
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsScript;
    [Header("Damage Objekt")]
    [SerializeField] private GameObject dethCamCenter;
    [SerializeField] private Animator bloodAnimator;
    [Header("UI Elements")]
    [SerializeField] private GameObject buttonsPanel;
    [SerializeField] private ScoreManagment scoreManagment;

    private bool damaging = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Damage(1);
            Destroy(other.gameObject);
        }
    }

    /*private IEnumerator ConstantDamage()
    {
        damaging = true;
        yield return new WaitForSeconds(0.5f);
        Damage(1);
        damaging = false;
    }*/
  public void Damage(int damageAmmount)
    {
        if (alive)
        {
            currentHealth -= damageAmmount;
            //bloodAnimator.SetTrigger("damage");
            if (currentHealth <= 0)
            {
                Die();
            }
        }
        
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && !damaging)
        {
            StartCoroutine(ConstantDamage());
        }
    }*/


    private void Die()
    {
        alive = false;
        /*Vector3 camPosition = fpsCamera.transform.position;
        fpsCamera.SetActive(false);
        dethCamCenter.SetActive(true);
        dethCamCenter.transform.position = camPosition;
        fpsScript.enabled = false;
        bloodAnimator.gameObject.SetActive(false);
        buttonsPanel.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        scoreManagment.WriteHighScore();*/
    }
}
