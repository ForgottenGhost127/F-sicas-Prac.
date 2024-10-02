using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatVanish : MonoBehaviour
{
    public float vanishDelay = 4f;
    private bool playerOnPlatform = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerOnPlatform = true;
            StartCoroutine(VanishAfterDelay());
        }
    }
    IEnumerator VanishAfterDelay()
    {
        yield return new WaitForSeconds(vanishDelay);
        if (playerOnPlatform)
        {
            gameObject.SetActive(false);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerOnPlatform = false;
        }
    }
}
