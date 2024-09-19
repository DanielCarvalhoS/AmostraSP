using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorColetavel : MonoBehaviour
{
    TMPro.TMP_Text text;
    public static int contagem;


    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();

    void OnEnable() => coletavel.OnCollected += OnCollectibleCollected;
    void OnDisable() => coletavel.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        contagem++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"Memórias:{contagem}/4";
    }
}