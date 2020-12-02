using UnityEngine;

public class BackGroundButtonScript : MonoBehaviour {

    public GameObject Ball1, Ball2, Ball3, Ball4, Ball5, Ball6, Ball7,BRed, BGreen, BBlue;
    public GameObject BRedText, BGreenText, BBlueText;

    public void BackGroundButtonClick()
    {
        Ball1.SetActive(false);
        Ball2.SetActive(false);
        Ball3.SetActive(false);
        Ball4.SetActive(false);
        Ball5.SetActive(false);
        Ball6.SetActive(false);
        Ball7.SetActive(false);

        BRed.SetActive(true);
        BGreen.SetActive(true);
        BBlue.SetActive(true);
        BRedText.SetActive(true);
        BGreenText.SetActive(true);
        BBlueText.SetActive(true);
    }
}