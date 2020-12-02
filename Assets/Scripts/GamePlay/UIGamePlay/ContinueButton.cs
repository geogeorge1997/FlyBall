using UnityEngine;

public class ContinueButton : MonoBehaviour {

    public GameObject TimerText;

    public void ContinueClick()
    {
        TimerText.SetActive(false);
        FindObjectOfType<VideoAdsScript>().Click();
    }
}