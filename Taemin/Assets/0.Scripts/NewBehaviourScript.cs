using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Spawn[] spawner;

    public Image map;
    public Sprite[] mapSp;

    public int nanEdo;

    public int[,] nanEdoMon = new int[,] {{5,3,0},{ 7,5,2 },{3,7,10}};

    public int map_num;

    public int monNum = 0;

    public int monCnt = 0;


    // Start is called before the first frame update

    public void isClear()
    {
        if(monNum == monCnt)
        {
            Debug.Log("클리어!!@");
            GameObject.Find("GameManager").GetComponent<GameManager>().Gohome();
            monNum = 0;
            monCnt = 0;
        }
    }

    public void Setmap()
    {
        monNum = 0;
        monCnt = 0;
        GameObject.Find("Taemin").GetComponent<Player>().SetStatus();
        GameObject.Find("taemin").GetComponent<TaminHealth>().currentHp = GameObject.Find("taemin").GetComponent<TaminHealth>().startHp;
        GameObject.Find("taemin").GetComponent<TaminHealth>().setHpbar();
        GameObject.Find("taemin").GetComponent<TaminHealth>().isDead = false;
      
        
        map.sprite = mapSp[map_num];
        
        Debug.Log("들어왓어용");
        switch (map_num) {
            case 0:
              
                spawner[0].spawnNum = nanEdoMon[nanEdo, 0];
                spawner[0].Sponstart();
                Debug.Log(nanEdoMon[nanEdo, 0]);
                monNum += spawner[0].spawnNum;
                Debug.Log(monNum);
               
                spawner[1].spawnNum = nanEdoMon[nanEdo, 1];
                spawner[1].Sponstart();
                monNum += spawner[1].spawnNum;
               
                spawner[2].spawnNum = nanEdoMon[nanEdo, 2];
                spawner[2].Sponstart();
                monNum += spawner[2].spawnNum;
                break;
            case 1:
               
                spawner[3].spawnNum = nanEdoMon[nanEdo, 0];
                spawner[3].Sponstart();
                monNum += spawner[3].spawnNum;
               
                spawner[4].spawnNum = nanEdoMon[nanEdo, 1];
                spawner[4].Sponstart();
                monNum += spawner[4].spawnNum;
                break;
            case 2:
               
                spawner[5].spawnNum = nanEdoMon[nanEdo, 0];
                spawner[5].Sponstart();
                monNum += spawner[5].spawnNum;
               
                spawner[6].spawnNum = nanEdoMon[nanEdo, 1];
                spawner[6].Sponstart();
                monNum += spawner[6].spawnNum;
                break;
            case 3:
               
                spawner[7].spawnNum = 1;
                spawner[7].Sponstart();
                monNum += spawner[7].spawnNum;
                break;

        }

    }


    // Update is called once per frame
    void Update()
    {
     
    }
}
