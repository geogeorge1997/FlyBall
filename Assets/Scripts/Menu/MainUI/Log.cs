using UnityEngine;

public class Log : MonoBehaviour {

    public GameObject LogStatus;
    public GameObject VibrationButton,/* MusicButton,*/ SoundButton;
    public int LogInt;

	public void LogClick()
    {
        LogInt = PlayerPrefs.GetInt("LogInt", 0);
        PlayerPrefs.SetInt("SettingsInt", 0);

        if (LogInt % 2 == 0)
        {
            LogStatus.SetActive(true);

            VibrationButton.SetActive(false);
            //MusicButton.SetActive(false);
            SoundButton.SetActive(false);
        }
        if(LogInt % 2 == 1)
        {
            LogStatus.SetActive(false);
        }
        LogInt = LogInt + 1;
        PlayerPrefs.SetInt("LogInt", LogInt);
    }

}