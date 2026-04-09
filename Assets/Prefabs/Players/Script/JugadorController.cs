using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D rigidbody2D;
    [SerializeField]float velocidad=1;
    void Start()
    {
        playerInput.GetComponent<PlayerInput>();
        rigidbody2D.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove(playerInput.actions["move"]);
    }

    void OnMove(InputAction input)
    {
       Vector2 moveVector=input.ReadValue<Vector2>();
       rigidbody2D.linearVelocity = moveVector * velocidad;
    }
}
