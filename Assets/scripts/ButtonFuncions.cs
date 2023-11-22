using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFuncions : MonoBehaviour
{
    public void StartButton()
    {
        GameManager.instance.ChangeScene("terrenos"); //cambiamos de escena con la funcion del game manager
    }
    public void ExitButton()
    {
        GameManager.instance.ExitTheGame(); //hacemos exit con la funcion del gamemanager
    }
}
