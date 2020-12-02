using UnityEngine;
using UnityEngine.UI;

public class SoundButtonScript : MonoBehaviour
{
    public int Value;
    public Sprite spriteOn;
    public Sprite spriteOff;
    public Button SoundButton;

    void Start()
    {
        Value = PlayerPrefs.GetInt("Sound", 1);
        if (Value == 1)
        {
            SoundButton.image.sprite = spriteOn;
        }
        else
        {
            SoundButton.image.sprite = spriteOff;
        }
    }

    public void ClickSound()
    {
        Value = PlayerPrefs.GetInt("Sound", 1);
        if (Value == 1)
        {
            SoundButton.image.sprite = spriteOff;
            PlayerPrefs.SetInt("Sound", 0);
        }
        else
        {
            SoundButton.image.sprite = spriteOn;
            PlayerPrefs.SetInt("Sound", 1);
        }
    }

}