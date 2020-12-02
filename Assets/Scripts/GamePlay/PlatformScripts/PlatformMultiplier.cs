using UnityEngine;

public class PlatformMultiplier : MonoBehaviour {

    public int i=1;
    public float platformDistance;
    public Transform PlatformClonePosition;
    public GameObject obstacleChild,FlyChild;
    public int value1, value2,childPositionRandom;

    void Start()
    {
        //Initilize tha values
        platformDistance = 80;                                 
    }

    public void FunMultiply()
    {
        GameObject prefab = Resources.Load("Platform") as GameObject;
        GameObject go = Instantiate(prefab);
        go.transform.localScale = new Vector3(2.5f, .1f, 1.6f);
        go.transform.position = new Vector3(0, 0, i * platformDistance);
        PlayerPrefs.SetFloat("makePlatform", i * platformDistance);
        PlayerPrefs.SetFloat("avg", platformDistance);
        i = i + 1;
        PlatformClonePosition = GameObject.Find("Platform(Clone)").transform;

        //Obstacle 1 Enabling
        value2 = Random.Range(0, 3);
        obstacleChild = go.gameObject.transform.GetChild(0).GetChild(value2).gameObject;
        obstacleChild.SetActive(true);

        //Obstacle 2 Enabling
        value2 = Random.Range(0, 3);
        obstacleChild = go.gameObject.transform.GetChild(1).GetChild(value2).gameObject;
        obstacleChild.SetActive(true);

        //Obstacle 3 Enabling
        value2 = Random.Range(0, 3);
        obstacleChild = go.gameObject.transform.GetChild(2).GetChild(value2).gameObject;
        obstacleChild.SetActive(true);

        //Obstacle 4 Enabling
        value2 = Random.Range(0, 3);
        obstacleChild = go.gameObject.transform.GetChild(3).GetChild(value2).gameObject;
        obstacleChild.SetActive(true);

        //Fly1
        childPositionRandom = Random.Range(0, 2);
        value1 = childPositionRandom;
        if (value1 == 1)
        {
            value2 = Random.Range(0, 3);
            FlyChild = go.gameObject.transform.GetChild(4).GetChild(value2).gameObject;
            FlyChild.SetActive(true);
        }

        Destroy(go, (10));
    }

}