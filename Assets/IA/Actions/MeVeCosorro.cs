using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) MeVeCosorroAction", menuName = "ScriptableObjects/Actions/MeVeCosorroAction")]
public class MeVeCosorro : Action
{
    public override bool Check(GameObject owner)
    {
        VisionScript playerVisionCmp = FindFirstObjectByType<VisionScript>();
        playerVisionCmp.enabled = true;

        if(playerVisionCmp.names.Contains(owner.name))
        {
            return true;
        }

       // playerVisionCmp.enabled = false;
        return false;
    }
}
