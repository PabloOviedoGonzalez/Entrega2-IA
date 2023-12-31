using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) PatrolState", menuName = "ScriptableObjects/States/PatrolState")]

public class PatrolState : State
{
    //public Vector3[] patrolPoints;
    //private int _currentIndex;

    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
        //_currentIndex = 0;
        owner.GetComponent<PatrolPoints>()._currentIndex = 0; //igualamos el current a 0
        base.Init(owner); //estado inicial del padre
       
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {

        //NavMesh agentComponent = owner.GetComponent<NavMesh>();
        if(owner.GetComponent<NavMeshAgent>().remainingDistance <= navMeshAgent.stoppingDistance) //me queda poco para llegar?
        {
            //_currentIndex++;
            owner.GetComponent<PatrolPoints>()._currentIndex++; //aumentamos en 1 el current
            //_currentIndex %= patrolPoints.Length;
            owner.GetComponent<PatrolPoints>()._currentIndex %= owner.GetComponent<PatrolPoints>().patrolPoints.Length; //evitamos q el current se salga del array
        }
        //navMeshAgent.SetDestination(patrolPoints[_currentIndex]);
        navMeshAgent.SetDestination(owner.GetComponent<PatrolPoints>().patrolPoints[owner.GetComponent<PatrolPoints>()._currentIndex].transform.position); //le damos el destino al agente
        return base.Run(owner);
    }
}
