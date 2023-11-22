using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) TimePassed", menuName = "ScriptableObjects/Actions/TimePassedAction")]

public class TimePassedAction : Action
{
    private float currentTime; //para hacer
    public float maxTime;      //crono

    public override void Init(GameObject owner)
    {
        currentTime = 0; //cada vez q se incie la accion resetamos el contador
    }

    public override bool Check(GameObject owner)
    {
        currentTime += Time.deltaTime; //framerate
            Debug.LogWarning(currentTime);
        if (currentTime > maxTime)
        {
            currentTime = 0;
            return true;
        }
        return false;
    }
}
