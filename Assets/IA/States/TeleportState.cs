using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Teleport", menuName = "ScriptableObjects/States/TeleportState")]

public class TeleportState : State
{

    public Vector3 terrainArea;


    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {

        base.Init(owner); //estado inicial del padre
    }

    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        Vector3 randomPoint = owner.transform.position + Random.insideUnitSphere * 500;
        NavMeshHit hit;
        if(NavMesh.SamplePosition(randomPoint, out hit, 5, NavMesh.AllAreas))
        {
            owner.transform.position = hit.position;
        }

        return base.Run(owner);
    }
}
