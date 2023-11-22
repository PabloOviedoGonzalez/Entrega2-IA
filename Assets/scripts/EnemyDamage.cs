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

        Health healthCmp = other.GetComponent<Health>(); //accedemos a la health
        if (healthCmp)
        {
            if (currentTime >= maxTime) // si el tiempo pasa
            {
                healthCmp.actualHealth -= damage; //le quitamos vida
                currentTime = 0; //y reiniciamos el tiempo
            }
        }
    }

    private void OnTriggerExit(Collider other) //si sale del trigger ponemos el crono a 0
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
        
