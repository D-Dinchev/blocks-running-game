using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerMovement Movement;
    
    void OnCollisionEnter(Collision colTarget)
    {
        if (colTarget.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
