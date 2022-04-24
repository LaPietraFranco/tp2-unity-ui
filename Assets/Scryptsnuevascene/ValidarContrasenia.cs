using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidarContrasenia : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;

    void Start()
    {
        contraseniacorrecta = "12345";
        cartelitoMsj.SetActive(false);
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
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
