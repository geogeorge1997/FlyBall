using UnityEngine;

public class ObstacleCall : MonoBehaviour {

    public int DestroyObstacle;

    public void OnCollisionEnter(Collision collision)
    {
        DestroyObstacle = PlayerPrefs.GetInt("DestroyObstacle", 0);
        if (DestroyObstacle == 1)
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("DestroyObstacle", 0);
            FindObjectOfType<EmptyObjectScript>().FreeLifeLost();
        }
        else
        FindObjectOfType<ScoreTextScript>().OutOccured();
    }
}