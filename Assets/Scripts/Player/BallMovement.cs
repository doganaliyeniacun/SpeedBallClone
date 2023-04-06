using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    [Header("[Components]")]
    [SerializeField] private Rigidbody rb;

    [Header("[Setting]")]
    public float moveSpeed = 10f;
    public float maxX = 5f;
    private bool turn = false;

    private void Update()
    {
        rb.velocity += new Vector3(0f, 0f, 1f) * moveSpeed * Time.fixedDeltaTime;
    }

    private void OnClick()
    {
        turn = !turn;
    }

    private void Turn(Vector2 direction)
    {
        if (direction.x == 0)
        {
            return;
        }

        float targetPos = Mathf.Clamp(direction.x * maxX, -maxX, maxX);
        Vector3 movement = new Vector3(targetPos, transform.position.y, transform.position.z);
        rb.MovePosition(movement);
    }

    
    private void OnMove(InputValue input)
    {
        Vector2 inputValue = input.Get<Vector2>();

        Turn(inputValue);
    }
}
