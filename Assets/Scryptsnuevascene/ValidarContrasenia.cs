using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidarContrasenia : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;

    void Start()
    {
        contraseniacorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
    }
        public void validarContrasenia()
        {
        contraseniaUsuario = ingresoUsuario.text;
        if(contraseniaUsuario == contraseniacorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
