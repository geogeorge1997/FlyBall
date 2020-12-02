using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour {

    public Text ScoreText;
    public int Score,Sound;
    public int HighSpeed, AverageSpeed, Level,Games,GameChance,TotalScore;
    public GameObject OutExplotionP,GBall,BGMSoundRef,FlySoundRef;
    public GameObject ContinueButton, NoThanksButton,TimerText;

    void Start()
    {
        HighSpeed = PlayerPrefs.GetInt("HighestSpeed", 0);
        AverageSpeed = PlayerPrefs.GetInt("AverageSpeed", 0);
        Games = PlayerPrefs.GetInt("Games", 0);
    }

    public void ScoreFuntion(int scoreParam)
    {
        Score = scoreParam;
        ScoreText.text = scoreParam+" Km/Hr";
    }

    public void OutOccured()
    {
        GameChance = PlayerPrefs.GetInt("GameChances", 0);

        if (GameChance == 0&&Score>30&& !(Application.internetReachability == NetworkReachability.NotReachable))
        {
            PlayerPrefs.SetInt("OutFlag", 1);
            PlayerPrefs.SetInt("GameChances",1);
            GBall.SetActive(false);
            ContinueButton.SetActive(true);
            NoThanksButton.SetActive(true);
            BGMSoundRef.SetActive(false);
            TimerText.SetActive(true);
        }
        else
        {
            BGMSoundRef.SetActive(false);
            FlySoundRef.SetActive(false);

            Sound = PlayerPrefs.GetInt("Sound", 1);
            if (Sound==1)
            {
                FindObjectOfType<OutSound>().OutSoundCall();
            }

            PlayerPrefs.SetInt("OutFlag", 1);
            ScoreText.text = "Out ";
            GBall.SetActive(false);
            OutExplotionP.SetActive(true);

            Games = Games + 1;
            PlayerPrefs.SetInt("Games", Games);

            if (Score > HighSpeed)
            {
                 PlayerPrefs.SetInt("HighestSpeed", Score);
            }

            TotalScore = PlayerPrefs.GetInt("TotalScore", 0);
            TotalScore = TotalScore + Score;
            PlayerPrefs.SetInt("TotalScore", TotalScore);

            Level = TotalScore / 1000;
            PlayerPrefs.SetInt("Level", Level);
            AverageSpeed = TotalScore / Games;
            PlayerPrefs.SetInt("AverageSpeed", AverageSpeed);

            PlayerPrefs.SetInt("Score", Score);
            PlayerPrefs.SetInt("GameChances", 0);
            PlayerPrefs.SetInt("GameChanceScore", 0);

            Invoke("LoadMenuSceneFuntion", 1.67f);
        }
    }

    public void ContinueCall()
    {
        PlayerPrefs.SetInt("GameChanceScore", Score);
        SceneManager.LoadScene("GamePlay");
    }

    public void NoThanksCall()
    {
        GBall.SetActive(true);
        Invoke("OutOccured", 0);  
    }

    public void LoadMenuSceneFuntion()
    {
        SceneManager.LoadScene("GamePlay");
    }

}