using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionScript : MonoBehaviour
{
    public List<string> names; //lista de strings

    private void OnTriggerEnter(Collider other) //si algun collider entra
    {
        names.Add(other.gameObject.name); //añadimos su nombre a la lista
    }

    private void OnTriggerExit(Collider other) //si sale
    {
        names.Remove(other.gameObject.name); // lo borramos
    }
}
