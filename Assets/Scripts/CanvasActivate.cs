using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCanvas : MonoBehaviour
{

    public GameObject TextCanvas;

    void Start()
    { // Se ejecuta al iniciar el juego
        TextCanvas.SetActive(false); // Desactiva el canvas al inicio del juego
    }

    private void OnTriggerEnter(Collider other)
    { // Se ejecuta al entrar en contacto con un collider
        if (other.tag == "Player")
        { // Si el objeto que entra en contacto tiene la etiqueta "Player"
            TextCanvas.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other)
    { // Se ejecuta al salir del contacto con un collider
        if (other.tag == "Player")
        { // Si el objeto que sale del contacto tiene la etiqueta "Player"
            TextCanvas.SetActive(false);
        }
    }
}
