using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) MeVeCosorroAction", menuName = "ScriptableObjects/Actions/MeVeCosorroAction")]
public class MeVeCosorro : Action
{
    public override bool Check(GameObject owner)
    {
        VisionScript playerVisionCmp = FindFirstObjectByType<VisionScript>(); //accedemos al visonscript
        playerVisionCmp.enabled = true; //si esta activo devolvemos true

        if(playerVisionCmp.names.Contains(owner.name)) //si este contiene al owner
        {
            return true;
        }

       // playerVisionCmp.enabled = false;
        return false;
    }
}
