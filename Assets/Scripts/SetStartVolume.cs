using UnityEngine;

public class SetStartVolume : MonoBehaviour
{
    private MusicManager _musicManager;

    void Start ()
    {
        _musicManager = FindObjectOfType<MusicManager>();
        var volume = PlayerPrefsManager.GetMasterVolume();
        _musicManager.ChangeVolume(volume);
    }
}
