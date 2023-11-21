using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Dead", menuName = "ScriptableObjects/States/DeadState")]

public class DeadState : State
{
    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
        
        base.Init(owner); //estado inicial del padre
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        Destroy(owner);

        return base.Run(owner);
    }
}
