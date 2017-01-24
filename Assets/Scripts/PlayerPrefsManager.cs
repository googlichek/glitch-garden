using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{
    public const string MASTER_VOLUME_KEY = "master_volume";
    public const string DIFFICULTY_KEY = "difficulty";
    public const string LEVEL_KEY = "level_unclocked_";

    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume out of range.");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if (level >= 0 && level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // Use 1 for true
        }
        else
        {
            Debug.LogError("Trying to unlock non-existing level.");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        var levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        var isLevelUnlocked = (levelValue == 1);

        if (level >= 0 && level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            return isLevelUnlocked;
        }
        else
        {
            Debug.LogError("Trying to query non-existing level.");
            return false;
        }
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= 0f && difficulty <= 1f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty out of range.");
        }
    }

    public static float GetDifficulty(float difficulty)
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
