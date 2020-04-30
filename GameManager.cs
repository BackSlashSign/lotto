using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager gameManager;
    private Vector3 spawnPos;
    public GameObject balls;
    public GameObject rid;
    public GameObject upWind;
    public int listRange = 44;
    public Transform ballSpawnPos;
    //private GameObject[] arrBalls = new GameObject[45];
    public List<GameObject> ballsList = new List<GameObject>();
    private int[] ballNum;
    int posSeed;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = ballSpawnPos.position;
        rid.SetActive(false);
        upWind.SetActive(false);
        StartCoroutine("SpawnBall");
    }

    IEnumerator SpawnBall()
    {
        for (int i = 0; i < 45; i++)
        {
            spawnPos.x += Random.Range(-2f, 2f);
            spawnPos.z += Random.Range(-2f, 2f);
            //arrBalls[i] = Instantiate(balls, spawnPos, Quaternion.identity);
            ballsList.Insert(i, Instantiate(balls, spawnPos, Quaternion.identity));

            BallInfo.instance.num = i + 1;

            spawnPos.x = 0f;
            spawnPos.z = 0f;
            yield return new WaitForSeconds(0.1f);
        }
        rid.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        upWind.SetActive(true);
    }

    public void OnClick_BallSelectOne()
    {
        int index = Random.Range(0, listRange);
        
        ballsList.RemoveAt(index);
        listRange--;
    }
    public void OnClick_BallSelectSix()
    {

    }

   
}
