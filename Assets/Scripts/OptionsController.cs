using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Slider VolumeSlider;
    public Slider DifficultySlider;
    public LevelManager LevelManager;
    private MusicManager _musicManager;

	void Start ()
	{
	    _musicManager = FindObjectOfType<MusicManager>();
	    VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
	    DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	void Update ()
	{
	    _musicManager.ChangeVolume(VolumeSlider.value);
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetDifficulty(DifficultySlider.value);
        LevelManager.LoadLevel("01a Start");
    }

    public void SetDefaults()
    {
        VolumeSlider.value = 0.33f;
        DifficultySlider.value = 2f;
    }
}
