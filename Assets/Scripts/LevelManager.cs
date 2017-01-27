using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float AutoLoadNextLevelAfter = 5f;

    void Start()
    {
        if (AutoLoadNextLevelAfter <= 0)
        {
            Debug.Log("Level auto load disabled.");
        }
        else
        {
            Invoke("LoadNextLevel", AutoLoadNextLevelAfter);
        }
    }

    /// <summary>
    /// Loads scene with a given name. 
    /// </summary>
    /// <param name="name">Scene name.</param>
	public void LoadLevel(string name)
    {
        Debug.Log("New level load: " + name);
		SceneManager.LoadScene(name);
	}

    /// <summary>
    /// Loads scene with the next index in build settings scene order. 
    /// </summary>
    public void LoadNextLevel()
    {
        Debug.Log("New level load: " + name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Quits from application (only for desktop build). 
    /// </summary>
	public void QuitRequest()
    {
        Debug.Log("Quit requested.");
		Application.Quit ();
	}
}
