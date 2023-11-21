using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFuncions : MonoBehaviour
{
    public void StartButton()
    {
        GameManager.instance.ChangeScene("terrenos");
    }
    public void ExitButton()
    {
        GameManager.instance.ExitTheGame();
    }
}
