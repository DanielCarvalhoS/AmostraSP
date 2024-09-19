using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saida : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("parede0"))
        {
        
                LoadScenes();
                
        }
    }
    void LoadScenes()
    {
        SceneManager.LoadScene("Inicio");
    }
}
