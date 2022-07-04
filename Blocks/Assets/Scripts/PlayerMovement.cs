using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SideWayForce = 500f;
    private bool _moveLeft = false;
    private bool _moveRight = false;

    void Start()
    {
        Application.targetFrameRate = 60; // don't let it to kill my pc
        rb.AddForce(0, 0, 1000f);
    }

    void Update()
    {
        _moveLeft = Input.GetKey("a") ? true : false;
        _moveRight = Input.GetKey("d") ? true : false;
    }

    void FixedUpdate()
    {
        // add a forward force to a player
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (_moveLeft)
        {
            rb.AddForce(-SideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (_moveRight)
        {
            rb.AddForce(SideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
