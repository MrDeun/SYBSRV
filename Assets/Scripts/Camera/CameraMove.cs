using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        this.transform.position = player.transform.position + transform.forward * -10f;
    }
}
