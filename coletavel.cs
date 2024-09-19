using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class coletavel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static event Action OnCollected;
    public static int total;

    void Awake() => total++;

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            OnCollected?.Invoke();
            Destroy(gameObject);
    }

}
