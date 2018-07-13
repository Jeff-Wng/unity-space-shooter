using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour {

	public Toggle fullscreenToggle;
	public Dropdown resolutionDropdown;
	public Dropdown textureQualityDropdown;
	public Slider musicVolumeSlider;
	public Button saveSettings;

	public AudioSource musicSource;

	//Resoultion array that holds multiple resoultion settings
	public Resolution[] resolutions;

	//GameSettings object
	public GameSettings gameSettings;

	void OnEnable() {

		gameSettings = new GameSettings ();

		fullscreenToggle.onValueChanged.AddListener (delegate {FullscreenToggle (); });
		resolutionDropdown.onValueChanged.AddListener (delegate {ResolutionChange (); });
		textureQualityDropdown.onValueChanged.AddListener (delegate {TextureQualityChange (); });
		musicVolumeSlider.onValueChanged.AddListener (delegate {MusicVolumeChange (); });
		saveSettings.onClick.AddListener (delegate {SaveSettings(); });


		resolutions = Screen.resolutions;
		foreach (Resolution resolution in resolutions) {

			resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));
		}

		LoadSettings ();
	}
	

	public void FullscreenToggle(){

		gameSettings.fullscreen = Screen.fullScreen = fullscreenToggle.isOn;
	}

	public void ResolutionChange(){

		Screen.SetResolution (resolutions [resolutionDropdown.value].width, resolutions [resolutionDropdown.value].height, Screen.fullScreen); 
		gameSettings.resolutionIndex = resolutionDropdown.value;
	}

	public void TextureQualityChange(){

		QualitySettings.masterTextureLimit = gameSettings.textureQuality = textureQualityDropdown.value;
	}

	public void MusicVolumeChange(){

		musicSource.volume = gameSettings.musicVolume = musicVolumeSlider.value;
	}

	public void SaveSettings(){

		string jsonData = JsonUtility.ToJson (gameSettings, true);
		File.WriteAllText (Application.persistentDataPath + "/gamesettings.json", jsonData);
		SceneManager.LoadScene ("Title Menu");
	}

	public void LoadSettings(){

		gameSettings = JsonUtility.FromJson<GameSettings> (File.ReadAllText(Application.persistentDataPath + "/gamesettings.json")); 

		musicVolumeSlider.value = gameSettings.musicVolume;
		textureQualityDropdown.value = gameSettings.textureQuality;
		resolutionDropdown.value = gameSettings.resolutionIndex;
		fullscreenToggle.isOn = gameSettings.fullscreen;
		Screen.fullScreen = gameSettings.fullscreen;


		resolutionDropdown.RefreshShownValue();
	}
}
