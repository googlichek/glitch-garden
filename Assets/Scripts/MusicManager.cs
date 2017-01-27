using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] LevelSoundArray;

    private AudioSource _audioSource;

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeVolume(float volume)
    {
        _audioSource.volume = volume;
    }

    private void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        var thisSceneIndex = SceneManager.GetActiveScene().buildIndex;
        var currentLevelSound = LevelSoundArray[thisSceneIndex];
        _audioSource = GetComponent<AudioSource>();

        if (currentLevelSound)
        {
            _audioSource.clip = currentLevelSound;
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }
}
