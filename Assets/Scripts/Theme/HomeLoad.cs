using UnityEngine;

public class HomeLoad : MonoBehaviour
{
    public GameObject CanvasHome, CanvasTheme;

    public void HomeLoadClick()
    {
        CanvasTheme.SetActive(false);
        CanvasHome.SetActive(true);
        FindObjectOfType<MainCamera>().BackGroundColorFuntion();
        FindObjectOfType<ThemeSprite>().ThemeImageFuntion();
    }
}