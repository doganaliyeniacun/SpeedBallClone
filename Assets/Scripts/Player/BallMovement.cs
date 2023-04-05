using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody rb;

    [Header("Setting")]
    public float moveSpeed = 10f;
    public float maxX = 5f;
    private bool turn = false;


    void Start()
    {
        rb.velocity = transform.forward * moveSpeed;
    }

    void FixedUpdate()
    {
        if (turn)
        {
            Move(-maxX);
        }
        else
        {
            Move(maxX);
        }
    }

    private void OnClick()
    {
        turn = !turn;
    }

    void Move(float direction)
    {
        float targetPos = Mathf.Clamp(direction, -maxX, maxX);
        Vector3 movement = new Vector3(targetPos, transform.position.y, transform.position.z);
        rb.MovePosition(movement);
    }
}
