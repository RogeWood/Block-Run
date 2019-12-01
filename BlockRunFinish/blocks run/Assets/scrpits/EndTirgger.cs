using UnityEngine;

public class EndTirgger : MonoBehaviour
{
	public GameManager gameManager;

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();
	}
}
