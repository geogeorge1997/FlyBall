using UnityEngine;

public class BallButtonScript : MonoBehaviour {

    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Ball6, Ball7, BRed, BGreen, BBlue;
    public GameObject BRedText, BGreenText, BBlueText;

	public void BallButtonClick()
    {
        Ball1.SetActive(true);
        Ball2.SetActive(true);
        Ball3.SetActive(true);
        Ball4.SetActive(true);
        Ball5.SetActive(true);
        Ball6.SetActive(true);
        Ball7.SetActive(true);

        BRed.SetActive(false);
        BGreen.SetActive(false);
        BBlue.SetActive(false);
        BRedText.SetActive(false);
        BGreenText.SetActive(false);
        BBlueText.SetActive(false);
    }
}