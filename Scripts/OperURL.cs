using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperURL : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=o-eMC7eiQ40&ab_channel=AffanDev");
        Debug.Log("Berjalan");

    }
}

