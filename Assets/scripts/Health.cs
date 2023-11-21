using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthImage;
    public float actualHealth;
    public float maxHealth;
    void Update()
    {
        healthImage.fillAmount = actualHealth / maxHealth;

        if(actualHealth <= 0)
        {
            GameManager.instance.ChangeScene("Menu");
        }
    }
    
    
}
