using UnityEngine;

public class playerCollision : MonoBehaviour
{
	public PlayerMovement movement;
	public GameManager GameManager;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
