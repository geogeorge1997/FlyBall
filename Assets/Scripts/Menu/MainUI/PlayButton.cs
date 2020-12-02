using UnityEngine;

public class PlayButton : MonoBehaviour {

    public GameObject CanvasHome,SpeedTextBox;

	public void  PlayButtonClick()
    {
        SpeedTextBox.SetActive(true);
        CanvasHome.SetActive(false);
        FindObjectOfType<BallMove>().PlayButton();
    }

}