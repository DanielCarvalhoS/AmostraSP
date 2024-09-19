using System.Collections;

using System.Collections.Generic;

using UnityEngine;


//coloca o script mo carro dos inimigos


public class movimentoInimigos: MonoBehaviour {

    bool Carro;
Vector3 velocidade;
// Use this for initialization


void Start () 
    {
        Carro = false;
        //jogo inicia e o caarro anda, basico. se caso n funcione, coloca o traslate no update.
        velocidade = new Vector3(0.0f,0.0f,0.0f);
}

// Update is called once per frame



void Update () 
{       
     velocidade.z = 0.15f;
     transform.Translate(velocidade);
        if (Carro == false && transform.position.z > 300)
        {
            Carro = true;
            Destroy(this.gameObject);
        }
    }
}
