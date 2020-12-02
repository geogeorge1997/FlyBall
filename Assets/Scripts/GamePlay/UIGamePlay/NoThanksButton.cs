using UnityEngine;

public class NoThanksButton : MonoBehaviour {

    public GameObject TimerText;

	public void NoThanksClick()
    {
        TimerText.SetActive(false);
        FindObjectOfType<ScoreTextScript>().NoThanksCall();
    }
}