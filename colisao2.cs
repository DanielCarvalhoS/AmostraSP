using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//coloca o script no carro


public class colisao2: MonoBehaviour 
{
   
// Use this for initialization

   void Start () 
   {
    
   }

/*assim como na primeira colisao, criei um trigger que
blablabla, só que esse trigger ativa quando entrar em colisao com os outro gameobject carros
(coloca o nome deles de carros para funcionar), e quando o trigger ativa, ele destroi o player
(coloca o nome do player de carro), depois de destroir ele recarrega a cena.*/
    private void OnCollisionEnter(Collision collision)
{
    switch (collision.gameObject.tag)
    {
            case "V1":
                Destroy(this.gameObject);
                   LoadScenes();
                break;
        }
}
    void LoadScenes()
    {
        SceneManager.LoadScene("São Paulo");
    }


    // Update is called once per frame



    void Update () 
   {
    

   }
}