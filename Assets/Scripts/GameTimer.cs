using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public int LevelSeconds = 100;

    private Slider _slider;
    private AudioSource _audioSource;
    private bool _isEndOfLevel;
    private LevelManager _levelManager;
    private GameObject _winLabel;

    void Start()
    {
        _slider = GetComponent<Slider>();
        _audioSource = GetComponent<AudioSource>();
        _levelManager = FindObjectOfType<LevelManager>();
        FindWinObject();
        _winLabel.SetActive(false);
    }

    void Update()
    {
        _slider.value = Time.timeSinceLevelLoad / LevelSeconds;

        if (Time.timeSinceLevelLoad >= LevelSeconds && !_isEndOfLevel)
        {
            _audioSource.Play();
            _winLabel.SetActive(true);
            StartCoroutine(LoadNextLevel(_audioSource.clip.length));
            _isEndOfLevel = true;
        }
    }

    private void FindWinObject()
    {
        _winLabel = GameObject.Find("You Win");
        if (!_winLabel)
        {
            Debug.LogWarning("Create proper object");
        }
    }

    private IEnumerator LoadNextLevel(float timeOut)
    {
        yield return new WaitForSeconds(timeOut);
        _levelManager.LoadNextLevel();
    }
}
