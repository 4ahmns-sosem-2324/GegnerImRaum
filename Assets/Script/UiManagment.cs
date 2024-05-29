using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManagment : MonoBehaviour
{
    [SerializeField] private Text healthValueText;
    [SerializeField] private Text scoreValueText;
    [SerializeField] private Image healthBar;
    [SerializeField] private LifeManagment lifeManagment;
    [SerializeField] private ScoreManagment scoreManagment;
    [SerializeField] private float healthBarValue;
    [SerializeField] private Color healthColor = new Vector4 (1f, 1f, 1f, 1f);

    void Start()
    {
        
    }

    private void Update()
    {
        healthValueText.text = lifeManagment.currentHealth.ToString();
        healthBarValue = lifeManagment.currentHealth / 10f;
        healthColor = new Vector4(1f, healthBarValue, healthBarValue, 1f);
        healthBar.color = healthColor;
        scoreValueText.text = scoreManagment.currentScore.ToString();
        healthBar.transform.localScale = new Vector3(healthBarValue, 1f, 1f);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
