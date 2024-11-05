using UnityEngine;

public class Move : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private float moveX;
    private float moveY;
    private Vector2 resultMove;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveX = 0f;
        moveY = 0f;

        if (Input.GetKey(KeyCode.D)) {
            moveX += 10f;
        }
        
        if (Input.GetKey(KeyCode.A)) {
            moveX -= 10f;
        }

        if (Input.GetKey(KeyCode.W)) {
            moveY += 10f;
        }

        if (Input.GetKey(KeyCode.S)) {
            moveY -= 10f;
        }


        resultMove = new Vector2(moveX, moveY).normalized;
        rigidbody.linearVelocity = resultMove;
    }
}
