using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptBalon : MonoBehaviour
{
    private bool balonLanzado = false;
    private Vector2 posicionInicial;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocidad = 5f;


    void Start()
    {
        posicionInicial = transform.position;
    }

    void OnSacar()
    {
        if (!balonLanzado)
        {
            lanzamiento();
            balonLanzado = true;
        }
    }

       public  void lanzamiento()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.linearVelocity = new Vector2(x * velocidad, y * velocidad);
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;
        transform.position = posicionInicial;
        balonLanzado = false;
    }
}
