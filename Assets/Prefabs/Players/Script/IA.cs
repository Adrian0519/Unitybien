using System;
using UnityEngine;

public class IA : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] private GameObject balon;
    private Vector2 posicionInicial;
    // Update is called once per frame

    void Start()
    {
      posicionInicial=transform.position;  
    }

    void Update()
    {
        Movimiento(); 
    }

    private void Movimiento()
    {
        float diferencia = balon.transform.position.y - transform.position.y;
        if (Mathf.Abs( diferencia) > 0.2f)
        {
            if (diferencia > 0)
            {
                transform.Translate(Vector2.up * velocidad * Time.deltaTime);
            }
            else{
                transform.Translate(Vector2.down * velocidad * Time.deltaTime);
            }
        }
    }

    public void reiniciar()
    {
        transform.position = posicionInicial;
    }
    
}
