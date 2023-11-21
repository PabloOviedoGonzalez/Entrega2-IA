using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) VariableGuard", menuName = "ScriptableObjects/States/VariableGuardState")]

public class VariableGuardState : State
{
    public Vector3 guardPoint; //el punto donde va a hacer guardia
    


    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
        guardPoint = owner.transform.position;
        base.Init(owner); //estado inicial del padre
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        Animator animator = owner.GetComponentInChildren<Animator>();
        animator.SetBool("Walk_Anim", false);
        animator.SetBool("Open_Anim", true);
        
        owner.GetComponent<NavMeshAgent>().SetDestination(guardPoint); //le damos un destino al agente

        return base.Run(owner);
    }
}
