using UnityEngine;
using UnityEngine.UI;

public class VibrationButtonScript : MonoBehaviour
{
    public int Value;
    public Sprite spriteOn;
    public Sprite spriteOff;
    public Button VibrationButton;

    void Start()
    {
        Value = PlayerPrefs.GetInt("Vibration", 1);
        if (Value == 1)
        {
            VibrationButton.image.sprite = spriteOn;
        }
        else
        {
            VibrationButton.image.sprite = spriteOff;
        }
    }

    public void ClickVibration()
    {
        Value = PlayerPrefs.GetInt("Vibration", 1);
        if (Value == 1)
        {
            VibrationButton.image.sprite = spriteOff;
            PlayerPrefs.SetInt("Vibration", 0);
        }
        else
        {
            VibrationButton.image.sprite = spriteOn;
            PlayerPrefs.SetInt("Vibration", 1);
        }
    }

}