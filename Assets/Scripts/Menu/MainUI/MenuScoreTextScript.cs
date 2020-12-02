using UnityEngine;
using UnityEngine.UI;

public class MenuScoreTextScript : MonoBehaviour {

    public Text ScoreText;
    public int Score;

	void Start ()
    {
        Score = PlayerPrefs.GetInt("Score", 0);
        ScoreText.text = "Score\n" + Score + " Km/Hr";
	}
}