using UnityEngine;
using UnityEngine.InputSystem;

public class JugadorController : MonoBehaviour
{
    [SerializeField]Rigidbody2D rigidbody2D;
    [SerializeField]float velocidad=1f;
    private float movimiento = 0f;
    // Update is called once per frame


    void OnMove(InputValue input)
    {
       Vector2 moveVector=input.Get<Vector2>();
       movimiento=moveVector.y;
    }


    void Update()
    {
        Vector2 vel = rigidbody2D.linearVelocity;
        vel.y = movimiento * velocidad;
        rigidbody2D.linearVelocity = vel;

    }
}
