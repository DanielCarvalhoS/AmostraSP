using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{
    Animator playerAnim;

    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) 
        {
            print("RunForward");
            playerAnim.SetBool("RunForward", true);
        }
        if (!Input.GetKey("w"))
        {
            print("RunForward");
            playerAnim.SetBool("RunForward", false);
        }
    }
}