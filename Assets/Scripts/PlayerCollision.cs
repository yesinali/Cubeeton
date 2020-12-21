using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovementScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovementScript.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
