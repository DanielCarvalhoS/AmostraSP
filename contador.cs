using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//ve o video que eu mandei pra saber one põe


public class contador : MonoBehaviour
{
    /*criei 3 variaveis, uma text que vai interagir com o texto da tela, uma float
    que vai fazer a contagem, e uma boolean que só recebe verdaddeiro ou falso, que vai
    servir pra saber se o tempo acabou.*/
    
    public float tempo;
    public bool fimtempo = false;

    void Start()
    {

    }

    // Update is called once per frame

    //um contador que vai decrementar 1 em 1 segundo o tempo ate acabar
    void contagem()
    {
        fimtempo = false;

        if (fimtempo && tempo > 0)
        {
            tempo -= Time.deltaTime;
            // se o tempo chegar a 0, o tempo vai zerar e vai carregar a proxima cena
            /* eu to desconfiamdo desse codigo, ent se n funcionar a parte de quamdo o tempo acaba
            coloca esse If abaixo no elsr do if de cima.*/
            if (tempo <= 0)
            {
                tempo = 0;
                SceneManager.LoadScene("Parque");
                fimtempo = true;
                
            }

        }
    }

    void Update()
    {
        // atusliza o tempo na tela (n sei como, só copiei o tutorial) e faz a contagem    
        contagem();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Parque");
        tempo = 10;
    }
}