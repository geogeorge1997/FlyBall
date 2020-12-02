using UnityEngine;
using UnityEngine.UI;

public class MusicButtonScript : MonoBehaviour
{
    public int Value;
    public Sprite spriteOn;
    public Sprite spriteOff;
    public Button MusicButton;
    public GameObject BGMSound;

    void Start()
    {
        Value = PlayerPrefs.GetInt("Music", 1);
        if (Value == 1)
        {
            MusicButton.image.sprite = spriteOn;
            BGMSound.SetActive(true);
        }
        else
        {
            MusicButton.image.sprite = spriteOff;
            BGMSound.SetActive(false);
        }
    }

    public void ClickMusic()
    {
        Value = PlayerPrefs.GetInt("Music", 1);
        if (Value == 1)
        {
            MusicButton.image.sprite = spriteOff;
            PlayerPrefs.SetInt("Music", 0);
            BGMSound.SetActive(false);
        }
        else
        {
            MusicButton.image.sprite = spriteOn;
            PlayerPrefs.SetInt("Music", 1);
            BGMSound.SetActive(true);
        }
    }

}