using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    [Header("[Components]")]
    [SerializeField] private Rigidbody rb;

    [Header("[Setting]")]
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float maxX = 5f;

    private float currentMoveSpeed = 0;
    private Delay delay = new Delay();


    private void Start()
    {
        currentMoveSpeed = moveSpeed;
    }


    private void Update()
    {
        rb.velocity += new Vector3(0, 0, 1f) * currentMoveSpeed * Time.deltaTime;

        if (delay.Execute(1))
        {
            currentMoveSpeed += 0.05f;
        }
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

    public void ResetSetting()
    {
        currentMoveSpeed = moveSpeed;
        rb.velocity = Vector3.zero;
    }
}
