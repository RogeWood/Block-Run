using UnityEngine;
using UnityEngine.SceneManagement;
public class credit : MonoBehaviour
{
	public GameManager GameManager;
    public void Quit()
	{
		Application.Quit();
		Debug.Log("quit");
	}
	public void Restart()
	{
		SceneManager.LoadScene("Level1");
	}

}
