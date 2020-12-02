using UnityEngine;
using UnityEngine.UI;

public class EmptyObjectScript : MonoBehaviour {

    public Text NotificationText;
    public GameObject NotificationTextGameObject;

	void Start ()
    {
        PlayerPrefs.SetInt("LogInt", 0);
        PlayerPrefs.SetInt("SettingsInt", 0);
	}

    public void FreeLifeGain()
    {
        NotificationTextGameObject.SetActive(true);
        NotificationText.text = "Free Life";
        Invoke("SetActive", .35f);
    }

    public void FreeLifeLost()
    {
        NotificationTextGameObject.SetActive(true);
        NotificationText.text = "Free Life Lost";
        Invoke("SetActive", .35f);
    }

    public void SetActive()
    {
        NotificationTextGameObject.SetActive(false);
    }

}