using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public Vector3 spawnPos;
    public GameObject balls;
    public GameObject rid;
    public GameObject upWind;
    public GameObject gameManager;

    int posSeed;
    // Start is called before the first frame update
    void Start()
    {
        rid.SetActive(false);
        upWind.SetActive(false);
        StartCoroutine("SpawnBall");
    }

    IEnumerator SpawnBall()
    {
        for(int i = 0; i < 45; i++)
        {
            spawnPos.x += Random.Range(-2f, 2f);
            spawnPos.z += Random.Range(-2f, 2f);
            Instantiate(balls,spawnPos,Quaternion.identity);
            spawnPos.x = 0f;
            spawnPos.z = 0f;
            yield return new WaitForSeconds(0.1f);
        }
        rid.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        upWind.SetActive(true);
        gameManager.SendMessage("GetBallArray", SendMessageOptions.DontRequireReceiver);
    }


}
