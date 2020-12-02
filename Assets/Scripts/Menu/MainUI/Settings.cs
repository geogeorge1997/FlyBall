using UnityEngine;

public class Settings : MonoBehaviour {

    public GameObject VibrationButton,/* MusicButton, */SoundButton;
    public GameObject LogStatus;
    public int SettingsInt;

	public void SettingsClick()
    {
        SettingsInt = PlayerPrefs.GetInt("SettingsInt", 0);
        PlayerPrefs.SetInt("LogInt", 0);

        if (SettingsInt % 2 == 0)
        {
            VibrationButton.SetActive(true);
            //MusicButton.SetActive(true);
            SoundButton.SetActive(true);
            LogStatus.SetActive(false);
        }
        if(SettingsInt % 2 == 1)
        {
            VibrationButton.SetActive(false);
            //MusicButton.SetActive(false);
            SoundButton.SetActive(false);
        }

        SettingsInt = SettingsInt + 1;
        PlayerPrefs.SetInt("SettingsInt", SettingsInt);
    }

}