using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public TaminHealth taminHealth;
    public GameObject enemy;
    public float spawnTime = 5f;
    public int spawnNum = 5;
    public int LateTime;



    public void Sponstart()
    {
        StartCoroutine(SpawnTimer());
    }

    IEnumerator SpawnTimer()
    {
        while (spawnNum!=0)
        {

            yield return new WaitForSeconds(spawnTime);
            Spawner();
        }
    }

    void Spawner()
    {
        if (taminHealth.isDead) return;
        if (spawnNum == 0) return;
        Instantiate(enemy, transform.position, transform.rotation);
        spawnNum--;
       
    }
}
