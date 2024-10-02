using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Nivel completado!");
            // Aquí puedes cargar la siguiente escena, o mostrar un mensaje de victoria
            // Ejemplo: SceneManager.LoadScene("NextLevelScene");
        }
    }
}
