using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) Hear", menuName = "ScriptableObjects/Actions/HearActions")] //crea una ruta en el menu de unity para crear un ScriptableObject que en nustro caso es una clase

public class HearAction : Action
{
    public float hearRadius; //RADIO DE LA ESFERA
    public override bool Check(GameObject owner)
    {
        RaycastHit[] hits = Physics.SphereCastAll(owner.transform.position, hearRadius, Vector3.up); //creamos un array de los hits q nos devuelven la posicion del owner


        foreach (RaycastHit hit in hits)  //comprobamos toda el area de la esfera 
        {
            if (hit.collider.GetComponent<PlayerMovement>()) //si "golpea" en algun punto al player
            {
                return true;
            }
        }
            return false;
    }

    public override void DrawGizmo(GameObject owner) //metodo para pintar los gizmos 
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(owner.transform.position, hearRadius);
    }
}
