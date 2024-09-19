using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraperson : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
    rotationX += Input.GetAxis("Mouse X") * sensitivity;
    rotationY += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationY, rotationX, 0f);
    }
}
