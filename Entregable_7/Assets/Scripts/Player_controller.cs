using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_controller : MonoBehaviour
{

    public TextMeshProUGUI arrowText;

   
    void Start()
    { arrowText.text = $"Pulsa cualquiera de las cuatro flechas"; }

    void Update()
    {
        ShowMessage(KeyCode.LeftArrow, $"Izquierda");
        ShowMessage(KeyCode.RightArrow, $"Derecha");
        ShowMessage(KeyCode.UpArrow, $"Arriba");
        ShowMessage(KeyCode.DownArrow, $"Abajo");
        ShowMessage(KeyCode.Return, $"Pium");
    }

    public void ShowMessage(KeyCode tecla, string message)
    {
        if (Input.GetKey(tecla))
        { arrowText.text = message; }
    }


}
