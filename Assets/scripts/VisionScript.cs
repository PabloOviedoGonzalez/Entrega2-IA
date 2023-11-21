using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionScript : MonoBehaviour
{
    public List<string> names;

    private void OnTriggerEnter(Collider other)
    {
        names.Add(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        names.Remove(other.gameObject.name);
    }
}
