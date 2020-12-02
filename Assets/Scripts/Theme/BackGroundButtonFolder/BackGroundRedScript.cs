using UnityEngine;
using UnityEngine.UI;

public class BackGroundRedScript : MonoBehaviour{

    public Text TextBox;
    private int ColorValue, IntValue;
    private string ValueString;
    private TouchScreenKeyboard keys;

    void Start()
    {
        ColorValue = PlayerPrefs.GetInt("BackGroundRed", 235);
        TextBox.text = ColorValue.ToString();
    }

    public void BackGroundRedButton()
    {
        PlayerPrefs.SetInt("BackGroundColorValue", 1);
        keys = TouchScreenKeyboard.Open(ValueString, TouchScreenKeyboardType.NumberPad);
    }

    void Update()
    {
        IntValue = PlayerPrefs.GetInt("BackGroundColorValue", 0);
        if (IntValue == 1)
        {
            if (!keys.active)
            {
                ValueString = keys.text;
                ColorValue = System.Int32.Parse(ValueString);
                TextBox.text = ValueString;
                if (ColorValue > 255)
                {
                    ColorValue = 255;
                    TextBox.text = "255";
                }
                PlayerPrefs.SetInt("BackGroundRed", ColorValue);
                FindObjectOfType<MainCamera>().BackGroundColorFuntion();
            }
        }
    }

}