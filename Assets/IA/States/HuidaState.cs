using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Huir", menuName = "ScriptableObjects/States/HuirState")]

public class HuidaState : State
{
    private Vector3 rndPos;
    private Animator animator;

    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
        base.Init(owner); //estado inicial del padre
        rndPos = new Vector3(Random.Range(owner.transform.position.x + 200, owner.transform.position.x - 200), owner.transform.position.y, Random.Range(owner.transform.position.z + 200, owner.transform.position.z - 200));
        //Le damos un destino random al agente
        animator = owner.GetComponentInChildren<Animator>(); //accedemos al animator
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        animator.SetBool("Walk_Anim", true); //cambiamos el bool de walk a true
        navMeshAgent.SetDestination(rndPos); //le decimos al agnete q vaya al punto random
        if(navMeshAgent.remainingDistance < 2) //si esta cerca del pùnto random le damos uno nuevo
        {
            rndPos = new Vector3(Random.Range(owner.transform.position.x + 200, owner.transform.position.x - 200), owner.transform.position.y, Random.Range(owner.transform.position.z + 200, owner.transform.position.z - 200));

        }
        return base.Run(owner);
    }
}
