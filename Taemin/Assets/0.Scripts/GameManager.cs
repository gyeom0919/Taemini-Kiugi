using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Animator Stage;
    public bool isopen = false;
    #region
    public int[] JellyGoldList;
    public Sprite[] JellySpriteList;
    public string[] JellyNameList;
    public int[] JellyJelatineList;
    public Sprite[] InGameFood;
    public int[] foodExpList;
    public static int foodExp = 1;
    public static bool GmisLive = true;
    public Animator Exitinven;
    public Vector3[] Point_List;
    public GameObject Invenob;
    public Spawn spawn1;
    public Spawn spawn2;
    public Spawn spawn3;


    public Camera MainCamera;
    public Camera WorldCamera;
    public NewBehaviourScript Spwonmgr;
    public void Gohome()
    {
        MainCamera.enabled = true;
        WorldCamera.enabled = false;

    }

    public void doshow()
    {
        if (!isopen)
        {
            Stage.SetTrigger("doShow");
            isopen = true;
        }
        else
        {
            Stage.SetTrigger("doHide");
            isopen = false;
        }
    }
    public void goMap1()
    {
        Spwonmgr.map_num = 0;
        Spwonmgr.nanEdo = 0;
        Spwonmgr.Setmap();
        GoWorld();
    }

    public void goMap2()
    {
        Spwonmgr.map_num = 0;
        Spwonmgr.nanEdo = 1;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap3()
    {
        Spwonmgr.map_num = 0;
        Spwonmgr.nanEdo = 2;
        Debug.Log("이동함니다빠슝");
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap4()
    {
        Spwonmgr.map_num = 1;
        Spwonmgr.nanEdo = 0;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap5()
    {
        Spwonmgr.map_num = 1;
        Spwonmgr.nanEdo = 1;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap6()
    {
        Spwonmgr.map_num = 1;
        Spwonmgr.nanEdo = 2;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap7()
    {
        Spwonmgr.map_num = 2;
        Spwonmgr.nanEdo = 0;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap8()
    {

        Spwonmgr.map_num = 2;
        Spwonmgr.nanEdo = 1;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap9()
    {
        Spwonmgr.map_num = 2;
        Spwonmgr.nanEdo = 2;
        Spwonmgr.Setmap();
        GoWorld();
    }
    public void goMap10()
    {
        Spwonmgr.map_num = 3;
        Spwonmgr.nanEdo = 3;
        Spwonmgr.Setmap();
        GoWorld();
    }

    public void GoWorld()
    {
        Stage.SetTrigger("doHide");
        isopen = false;
        WorldCamera.enabled = true;
        MainCamera.enabled = false;

    }

    #endregion

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }

    public void InventoryExit()
    {
        Exitinven.SetTrigger("doHide");
        Variables.Object(Invenob).Set("IsClick", false);
        Variables.ActiveScene.Set("isLive", true);



    }
}
