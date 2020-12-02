using UnityEngine;

public class ThemeLoad : MonoBehaviour {

    public GameObject CanvasHome, CanvasTheme;

	public void ThemeButtonClick()
    {
        CanvasHome.SetActive(false);
        CanvasTheme.SetActive(true);
    }
}