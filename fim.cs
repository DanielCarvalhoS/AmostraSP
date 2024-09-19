using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fim : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("parede0") && contadorColetavel.contagem == 4)
        {
        
                LoadScenes();
                
        }
    }
    void LoadScenes()
    {
        SceneManager.LoadScene("Fim");
    }
}
