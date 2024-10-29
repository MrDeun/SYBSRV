using UnityEngine;

public class Gravity : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        collision.GetComponentInParent<Rigidbody2D>().gravityScale = 0f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponentInParent<Rigidbody2D>().gravityScale = 1f;
    }
}
