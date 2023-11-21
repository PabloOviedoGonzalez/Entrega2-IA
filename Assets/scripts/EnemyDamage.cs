using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    public float maxTime, currentTime;

    private void Start()
    {
        currentTime = maxTime;
    }

    private void OnTriggerStay(Collider other)
    {
        currentTime += Time.deltaTime;

        Health healthCmp = other.GetComponent<Health>();
        if (healthCmp)
        {
            if (currentTime >= maxTime)
            {
                healthCmp.actualHealth -= damage;
                currentTime = 0;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        currentTime = 0;
    }

    //private void (Collision collision)
    //{
    //    Health healthCmp = collision.gameObject.GetComponent<Health>();
    //    if (healthCmp)
    //    {
    //        healthCmp.actualHealth -= damage;
    //    } 
    //}
}
        
