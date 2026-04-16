using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pelota,ia;
    public int puntosJugador=0;
    public int puntosIa = 0;
    public bool pvp;
    [Serialize] public TextMeshPro marcadorUi;

    public void puntuacion(int identificador)
    {
        if (identificador==1)
        {
            puntosJugador++;
        }else if (identificador==2) {
            puntosIa++;
    }

        if (puntosJugador >= 7)
        {
            Debug.Log("Gana jugador");
            StartCoroutine(ResetCorrutine());
            return;
        }
        else if(puntosIa >= 7) {
            Debug.Log("Gana CPU");
            StartCoroutine(ResetCorrutine());
            return;
        }
        StartCoroutine(ResetCorrutine());
    }

    private IEnumerator ResetCorrutine()
    {
       yield return new WaitForSeconds(0.5f);
        ResetPosicion();     
    }

    private void ResetPosicion()
    {
        pelota.GetComponent<ScriptBalon>().ResetBall();
        ia.GetComponent<IA>().reiniciar();
    }

   public void marcadorActualizar()
    {
        marcadorUi.text=puntosJugador + " " + puntosIa;
    }
    
}
