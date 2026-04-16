using UnityEngine;

public class MarcadorGoles : MonoBehaviour
{
    [SerializeField]private int porteria;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pelota")){
            gameManager.puntuacion(porteria);
        }
    }

}
