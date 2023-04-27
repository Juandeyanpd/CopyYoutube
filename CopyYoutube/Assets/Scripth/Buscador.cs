using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buscador : MonoBehaviour
{
    public TMP_Text textPro; 

    public void Buscar()
    {
        string text = textPro.text;
        Application.OpenURL(text);
    }
}
