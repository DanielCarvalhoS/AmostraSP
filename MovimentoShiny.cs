                                                                                                                                                                                                            using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentoShiny : MonoBehaviour
{
    Vector3 m, pos;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "parede":
                LoadScenes();
                break;
            case "parede0":
                m.z = -0.09f;
                pos = new Vector3(0f, 1f, 150f);
                transform.position = pos;
                transform.Rotate(0f, 0f, 0f);
                break; 
        }
    }
    void LoadScenes()
    {
        SceneManager.LoadScene("Parque");
    }

    // Update is called once per frame
    void Update()
    {
        
        }
    }
