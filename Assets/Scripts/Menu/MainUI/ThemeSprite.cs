using UnityEngine;
using UnityEngine.UI;

public class ThemeSprite : MonoBehaviour {

    public Sprite spriteBall1, spriteBall2, spriteBall3, spriteBall4, spriteBall5, spriteBall6, spriteBall7;
    public int spriteBallInt;
    public Image ThemeImage;

	void Start ()
    {
        Invoke("ThemeImageFuntion", 0);
    }

    public void ThemeImageFuntion()
    {
        spriteBallInt = PlayerPrefs.GetInt("Ball", 1);

        if (spriteBallInt == 1)
        {
            ThemeImage.sprite = spriteBall1;
        }
        else if (spriteBallInt == 2)
        {
            ThemeImage.sprite = spriteBall2;
        }
        else if (spriteBallInt == 3)
        {
            ThemeImage.sprite = spriteBall3;
        }
        else if (spriteBallInt == 4)
        {
            ThemeImage.sprite = spriteBall4;
        }
        else if (spriteBallInt == 5)
        {
            ThemeImage.sprite = spriteBall5;
        }
        else if (spriteBallInt == 6)
        {
            ThemeImage.sprite = spriteBall6;
        }
        else if (spriteBallInt == 7)
        {
            ThemeImage.sprite = spriteBall7;
        }

    }

}