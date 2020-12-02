using UnityEngine;
using UnityEngine.UI;

public class TimerScripts : MonoBehaviour {

    public int timeLeft = 181;
    public Text TimerText;
    public int intTime;

    void Update()
    {
        timeLeft = timeLeft - 1;
        if (timeLeft < 0)
        {
            FindObjectOfType<ScoreTextScript>().OutOccured();
            gameObject.SetActive(false);

        }
        if (timeLeft > 0 && timeLeft <= 60)
        {
            intTime = 1;
        }
        else if (timeLeft > 60 && timeLeft <= 120)
        {
            intTime = 2;
        }
        else if (timeLeft > 120 && timeLeft < 181)
        {
            intTime = 3;
        }
        else
        {
            intTime = 0;
        }
        TimerText.text = intTime.ToString();
    }
}