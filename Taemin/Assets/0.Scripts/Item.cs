using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Bolt;


public class Item : MonoBehaviour
{
    public Button FoodBtn;
    public Button InvenBtn;

    #region 
    public Sprite[] WeaponSp;
    public Sprite[] ArmorSp; 
    public Sprite[] ShildSp;
    public Sprite[] HeadSp;
    public Sprite[] AcessorySp;
  
    public int testvalue = 1;

    public string[] Itemtype = { "무기", "갑옷", "투구" , "악세서리" , "방패" , "재료"};

    public Image[] Inventorylist;
    public Image[] InventoryItemlist;

    public bool[] CheakInventorylist = new bool[15];

    public Text nameText;
    public Text statusText;
    public Text discriptionText;

    public GameItem nowGameItem;
    public Image nowimage;
    public Image nowimage_2;

    public Image lastClick;
    public Image Weapon;
    public Image head;
    public Image sheld;
    public Image armo;
    public Image acessory;

    public Image Weapon_2;
    public Image head_2;
    public Image sheld_2;
    public Image armo_2;
    public Image acessory_2;

    public List<GameItem> Itemlist = new List<GameItem>();

    public CreatTable creatTable;

    public void Start()
    {
        Debug.Log(Itemtype[4]);
        Debug.Log(Itemtype[5]);


        creatTable = GameObject.Find("MakeTable").GetComponent<CreatTable>();

        Itemlist.Add(new GameItem(WeaponSp[0], 0, "낡아빠진 구리검", "공격력: 5", "창고에서 주어왔다.\n피격시 파상풍에 걸릴수 있다.", Itemtype[0], 5 , 100 , 5 , 1000 , 10));
        Itemlist.Add(new GameItem(WeaponSp[1], 1, "박보검", "공격력: 23", "잘생겼다.", Itemtype[0], 23, 90, 10, 3000,20));
        Itemlist.Add(new GameItem(WeaponSp[2], 2, "청록의검", "공격력: 45", "착용시 꽃과 나비\n모기들이 몰려온다.", Itemtype[0], 45, 80, 18, 7000,30));
        Itemlist.Add(new GameItem(WeaponSp[3], 3, "빛의검", "공격력: 70", "어느왕국의 용사가 사용하던검이다.\n눈이부시니 선글라스 착용을 권장한다.", Itemtype[0], 70, 60, 30, 15000,40));
        Itemlist.Add(new GameItem(WeaponSp[4], 4, "거대한 재앙", "공격력: 100", "고대의 어느 왕이 사용하던검이다.\n짜장면을 코로먹을 수도있다", Itemtype[0], 100,  35, 50, 999999999,50));

        Itemlist.Add(new GameItem(ArmorSp[0], 5, "가죽 갑옷", "방어력: 5", "태민이가 먹고 남은 소가죽으로\n만든 가죽 갑옷 상당히 질기다", Itemtype[1], 5, 100, 5, 1000,8));
        Itemlist.Add(new GameItem(ArmorSp[1], 6, "동 갑옷", "방어력: 8", "동으로 만든 갑옷\n광물로만들어 단단하다.", Itemtype[1], 8, 90, 10, 3000,15));
        Itemlist.Add(new GameItem(ArmorSp[2], 7, "철 갑옷 ", "방어력: 14", "철로 만든 갑옷.\n반짝거리며 광물로 만들어 단단하다.", Itemtype[1], 14 , 80, 14, 5000,25));
        Itemlist.Add(new GameItem(ArmorSp[3], 8, "금 갑옷", "방어력: 23", "영롱하며 상대를 매혹하는 색을 지니고 있다.", Itemtype[1], 23,  80, 18, 7000,35));
        Itemlist.Add(new GameItem(ArmorSp[4], 9, "붕대 갑옷", "방어력: 32", "갑옷이 붕대에 감싸져있다.\n주 광물이 무었인지 알 수 없다.", Itemtype[1], 32, 60, 30, 15000,40));
        Itemlist.Add(new GameItem(ArmorSp[5], 10, "챌린저 갑옷", "방어력: 45", "페2커가 사용한 갑옷. \n엄청난 무빙에 흠집조차 낼 수 없다.", Itemtype[1], 45, 35, 50, 999999999,50));

        Itemlist.Add(new GameItem(HeadSp[0], 11, "태민이의 안경", "체력: 200", "태민이가 자주 쓰는 안경이다.\n 자물쇠가 걸려있다.", Itemtype[2], 200 , 100, 5, 1000,8));
        Itemlist.Add(new GameItem(HeadSp[1], 12, "동 헬멧", "체력: 500", "동으로 만든 헬멧.\n 광물로 만들어 단단하다.", Itemtype[2], 500, 90, 10, 3000,20));
        Itemlist.Add(new GameItem(HeadSp[2], 13, "철 헬멧 ", "체력: 700", "철로 만든 헬멧. 반짝거리며\n광물로 만들어 단단해보인다.", Itemtype[2], 700, 85, 15, 7000,30));
        Itemlist.Add(new GameItem(HeadSp[3], 14, "금 헬멧", "체력: 1200", "금으로 만든 헬멧. 영롱하며\n상대를 매혹하는 색을 지니고 있다.", Itemtype[2], 1200,  80, 18, 7000,35));
        Itemlist.Add(new GameItem(HeadSp[4], 15, "주술사의 헬멧", "체력: 1800", "김태민을 소환한 잘생긴 주술사가\n쓰던 헬멧이다. 성능이 상당하다", Itemtype[2], 1800, 60, 30, 15000,45));
        Itemlist.Add(new GameItem(HeadSp[5], 16, "챌린저 헬멧", "체력: 3000", "페2커가 사용한 헬멧 \n롤드컵 3회우승자의 넘치는 체력이 담겨있다.", Itemtype[2], 3000, 35, 50, 999999999,50));

        Itemlist.Add(new GameItem(ShildSp[0], 17, "나무 방패 ", "방어력: 5", "나무로 만들어 내구성이 \n약하고 단단하지 않은 방패.", Itemtype[4], 5, 100, 5, 1000,10));
        Itemlist.Add(new GameItem(ShildSp[1], 18, "철 방패", "방어력: 11", "철로 만든 방패. 반짝거리며 \n광물로 만들어 단단하다.", Itemtype[4], 11, 90, 10, 3000,20));
        Itemlist.Add(new GameItem(ShildSp[2], 19, "금 방패 ", "방어력: 22", "금으로 만든 방패.  \n미끄러우며 상대의 공격을 흘려낸다.", Itemtype[4], 22, 80, 18 , 7000,30));
        Itemlist.Add(new GameItem(ShildSp[3], 20, "괴물방패 ", "방어력: 31", "그웨에엙에엥 \n에에렝우에렌엑나아낭달", Itemtype[4], 31, 60, 30, 15000,40));
        Itemlist.Add(new GameItem(ShildSp[4], 21, "챌린저 방패", "방어력: 40", "페2커가 사용한 방패 \n누구와 라인전을해도 뚫리지 않던 강인함이 담겨있다.", Itemtype[4], 40,  35, 50, 999999999,50));

        Itemlist.Add(new GameItem(AcessorySp[0], 22, "푸른 수호자", "방어력과 체력을 대폭올려 바위처럼 단단하게 만들어준다.", Itemtype[3], 1));
        Itemlist.Add(new GameItem(AcessorySp[1], 23, "매혹의 루비반지", "FLEX!, 골드와 경험치 획득량을 늘려준다.", Itemtype[3], 2)); 
        Itemlist.Add(new GameItem(AcessorySp[2], 24, "SS급 쥬얼링", "치명적이고 강력한 찌르기!", Itemtype[3], 3));
        Itemlist.Add(new GameItem(AcessorySp[3], 25, "검은 재앙", "-훠훠", Itemtype[3],4));

        
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[0], 26, "초록물약", "어느연구소에서 떨어진 초록물약\n 메론맛이다.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[1], 27, "붉은물약", "어느연구소에서 떨어진 붉은물약\n 딸기맛이다. ", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[2], 28, "별사탕", "어느연구소에서 떨어진 별사탕\n 건빵과먹으면 맛있다.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatSecondItemMeterial[0], 29, "미스릴조각", "미스릴파편, 비싼값에 팔 수 있다.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatSecondItemMeterial[1], 30, "오리칼륨조각", "오리칼륨 파편, 보기보다 말랑하다", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatSecondItemMeterial[2], 31, "운석조각", "앗뜨거!", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatThirdItemMeterial[0], 32, "붉은가루", "맵다", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatThirdItemMeterial[1], 33, "푸른가루", "떫다", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatThirdItemMeterial[2], 34, "의문의보석", "영롱한빛을 내고있다. \n 반지로 가공할 수 있을거같다.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatForthItemMeterial[0], 35, "재앙의 눈", "모든것을 감시한다", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatForthItemMeterial[1], 36, "재앙의 두개골", "흉측하다", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatForthItemMeterial[2], 37, "재앙의 꽃", "북쪽을 바라보며 운다.", Itemtype[5]));
        Itemlist.Add(new GameItem(creatTable.CreatFirstItemMeterial[3], 38, "재앙의 피", "끈적한 재앙의 느낌이난다.", Itemtype[5]));


        for (int i = 0; i < 15; i++)
        {
            CheakInventorylist[i] = false;
        }

        Debug.Log("gkgkgk");
        GetItem(Itemlist[0]);
    }

    public void GetItem(GameItem item)
    {
        for(int i=0; i<15; i++)
        {
           
            if (CheakInventorylist[i] == false)
            {
                InventoryItemlist[i].GetComponent<Click>().nowItem = item;
                CheakInventorylist[i] = true;              
                Inventorylist[i].sprite = item.sprite;
                Inventorylist[i].color = new Color(255, 255, 255, 255);
                
               
                break;
            }

        }
    }

    public void GetWearingItem(Image img, Image img_2)
    {
        //아이템을 장착해줌
        img.GetComponent<Click>().nowItem = nowGameItem;
        img.color = new Color(0.3058824f, 0.2901961f, 0.3058824f, 1f);
        img_2.color = new Color(255, 255, 255, 255);
        img_2.sprite = nowGameItem.sprite;
        nowGameItem.isequipting = true;
    }

    public void Setdeiscription(GameItem item)
    {
        nameText.text = item.name + "[" + item.ItemType + "]";
        if(item.isacesoryCnt == 0 || item.ItemType == "재료")
        {
            statusText.text = item.status;
        }
        else
        {
            statusText.text = "";
        }
        discriptionText.text = item.discription;
    }

    public void Deletedeiscription()
    {
        nameText.text = "";
        statusText.text = "";
        discriptionText.text = "";
    }

    public void SetItem() 

    {
       
        if (!nowimage.GetComponent<Click>().isequipt)
        {
            
            if(nowGameItem.ItemType == "재료")
            {
                return;
            }
            switch (nowGameItem.ItemType)
            {
                case "무기":
                    if (Weapon.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(Weapon, Weapon_2);
                    Weapon.GetComponent<Click>().isequipting = true;
                    GameObject.Find("Taemin").GetComponent<Player>().Str += Weapon.GetComponent<Click>().nowItem.status_int;
                    break;
                case "투구":
                    if (head.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(head, head_2);
                    head.GetComponent<Click>().isequipting = true;
                    GameObject.Find("Taemin").GetComponent<Player>().Hp += head.GetComponent<Click>().nowItem.status_int;
                    break;
                case "방패":
                    if (sheld.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(sheld, sheld_2);
                    sheld.GetComponent<Click>().isequipting = true;
                    GameObject.Find("Taemin").GetComponent<Player>().Dex += sheld.GetComponent<Click>().nowItem.status_int;
                    break;
                case "갑옷":
                    if (armo.GetComponent<Click>().isequipting == true)
                        return;
                    GetWearingItem(armo, armo_2);
                    GameObject.Find("Taemin").GetComponent<Player>().Dex += armo.GetComponent<Click>().nowItem.status_int;
                    armo.GetComponent<Click>().isequipting = true;
                    break;
                case "악세서리":
                    if (acessory.GetComponent<Click>().isequipting == true)
                        return;
                    switch (nowGameItem.isacesoryCnt)
                    {
                        case 1:
                            nowGameItem.acessory1_StatusSetting();
                            break;
                        case 2:
                            nowGameItem.acessory2_StatusSetting();
                            break;
                        case 3:
                            nowGameItem.acessory3_StatusSetting();
                            break;
                        case 4:
                            nowGameItem.acessory4_StatusSetting();
                            break;
                    }
                    GetWearingItem(acessory, acessory_2);
                    acessory.GetComponent<Click>().isequipting = true;
                    break;
            }
            CheakInventorylist[nowimage.GetComponent<Click>().num] = false;
            nowGameItem = null;
            nowimage.GetComponent<Click>().Delite();
            nowimage_2.sprite = null;
            nowimage_2.color = new Color(0, 0, 0, 0);

        }

        nowimage.GetComponent<Click>().nowItem = null;

    }

    public void OutItem()
    {
        

        if (nowimage.GetComponent<Click>().isequipt)
        {
            bool kanitsem = false;
            //아이템창이 한칸도없다면 리턴
            for (int i = 0; i < 15; i++)
            {
                if (!CheakInventorylist[i])
                {
                    kanitsem = true;
                }

            }


            if (!kanitsem)
            {
                return;
            }
            switch (nowGameItem.isacesoryCnt)
            {
                case 1:
                    nowGameItem.acessory1_StatusOut();
                    break;
                case 2:
                    nowGameItem.acessory2_StatusOut();
                    break;
                case 3:
                    nowGameItem.acessory3_StatusOut();
                    break;
                case 4:
                    nowGameItem.acessory4_StatusOut();
                    break;
            }
            GetItem(nowGameItem);
            
        }
        else
        {
            GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu += nowGameItem.dropGanghwasu;
            CheakInventorylist[nowimage.GetComponent<Click>().num] = false;
            InventoryItemlist[nowimage.GetComponent<Click>().num].GetComponent<Click>().nowItem = null;
        }
            
        switch (nowGameItem.ItemType)
        {
            
            case "무기":
                Debug.Log("1");
                Weapon.GetComponent<Click>().isequipting = false;
                if(nowimage.GetComponent<Click>().isequipt == true)
                GameObject.Find("Taemin").GetComponent<Player>().Str -= nowGameItem.status_int;
                Debug.Log("2");
                break;
            case "투구":
                
                head.GetComponent<Click>().isequipting = false;
                if (nowimage.GetComponent<Click>().isequipt == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Hp -= nowGameItem.status_int;
                break;
            case "방패":
                
                sheld.GetComponent<Click>().isequipting = false;
                if (nowimage.GetComponent<Click>().isequipt == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                break;
            case "갑옷":
                if (nowimage.GetComponent<Click>().isequipt == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                armo.GetComponent<Click>().isequipting = false;
                break;
            case "악세서리":         
                acessory.GetComponent<Click>().isequipting = false;
                nowGameItem.isequipting = false;
                break;
        }
        nowGameItem.isequipting = false;
        nowGameItem = null;
        nowimage.GetComponent<Click>().Delite();
        nowimage_2.sprite = null;
        nowimage.color = new Color(0, 0, 0, 0);
        nowimage_2.color = new Color(0, 0, 0, 0);
       
    }
    public void test()
    {
        GetItem(Itemlist[testvalue]);
        testvalue += 1;
    }


    #endregion

    #region
    public Animator anmator;
    public Animator inventoryAnim;

    public Image upgradeImage;
    public Text upgradeName;
    public Text upgradeStatus;
    public Text upgradeDeiscription;
    public Text upgradeUseGangHwaSu;
    public Text persent;

    public void UpgradeOpen()
    {
        if (nowGameItem.isacesoryCnt != 0 || nowGameItem.ItemType == "재료")
        {
            return;
        }
        if (nowGameItem.howhighGanghwa == 5)
        {
            upgradeUseGangHwaSu.text = "강화수치가 최대치에 도달하였습니다.";
            persent.text = "승급 소요골드 :" + nowGameItem.upGradeGold;
        }
        if (nowGameItem != null)
        {
            SetUpgradeDeiscription();
            anmator.SetTrigger("doShow");
            inventoryAnim.SetTrigger("doHide");
        }
        FoodBtn.interactable = false;
        InvenBtn.interactable = false;


    }
    public void UpgradeClose()
    {
        anmator.SetTrigger("doHide");
        inventoryAnim.SetTrigger("doShow");
        FoodBtn.interactable = true;
        InvenBtn.interactable = true;
    }

    public void SetUpgradeDeiscription()
    {
        upgradeImage.sprite = nowGameItem.sprite;
        upgradeName.text = nowGameItem.name;
        upgradeStatus.text = nowGameItem.status;
        upgradeDeiscription.text = nowGameItem.discription;
        upgradeUseGangHwaSu.text = "필요한 강화서: " + nowGameItem.useGangHwaSu.ToString();
        persent.text = "강화 성공률: "+nowGameItem.persent.ToString()+"%";

    }

    public void DoUpgrade()
    {
        if (nowGameItem.howhighGanghwa == 5)
        {
            upgradeUseGangHwaSu.text = "강화수치가 최대치에 도달하였습니다.";
            persent.text = "승급 소요골드 :" + nowGameItem.upGradeGold;
            return;
        }
        Debug.Log(nowGameItem.useGangHwaSu); 
        Debug.Log(GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu);
        if(GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu< nowGameItem.useGangHwaSu)
        {
            return;
        }
        GameObject.Find("Taemin").GetComponent<Player>().GangHwaSu -= nowGameItem.useGangHwaSu;
        
        if (nowGameItem.persent >= Random.Range(1, 101))
        {
            Debug.Log("강화성공");
            nowGameItem.howhighGanghwa += 1;
            nowGameItem.name = nowGameItem.inosnetname + "+" + nowGameItem.howhighGanghwa.ToString();
            switch (nowGameItem.ItemType)
            {
                case "무기":
                    nowGameItem.status_int += 2;
                    if(nowGameItem.isequipting == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Str += 2;
                    nowGameItem.status = "공격력:" + nowGameItem.status_int;
                    break;
                case "투구":
                    nowGameItem.status_int += 30;
                    if (nowGameItem.isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Hp += 30;
                    nowGameItem.status = "체력:" + nowGameItem.status_int;
                    break;
                case "방패":
                case "갑옷":
                    nowGameItem.status_int += 1;
                    if (nowGameItem.isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex += 1;
                    nowGameItem.status = "방어력:" + nowGameItem.status_int;
                    break;
               
            }
             
        }
        else
        {
            Debug.Log("강화실패");
        }
        SetUpgradeDeiscription();
        Setdeiscription(nowGameItem);
        if (nowGameItem.howhighGanghwa == 5)
        {
            upgradeUseGangHwaSu.text = "강화수치가 최대치에 도달하였습니다.";
            persent.text = "승급 소요골드 :" + nowGameItem.upGradeGold;
           
        }
    }

    public void DoPromote()
    {
        bool cheak = false;
        if (Variables.Saved.Get<int>("Jelatine") < nowGameItem.upGradeGold || nowGameItem.howhighGanghwa != 5)
        {
            return;
        }
        Variables.Saved.Set("Jelatine", Variables.Saved.Get<int>("Jelatine") - nowGameItem.upGradeGold );
        // 현재 게임아이템을 
        //InventoryItemlist[nowGameItem.number].GetComponent<Click>().nowItem = Itemlist[nowGameItem.number+1];
        // nowGameItem = InventoryItemlist[nowGameItem.number].GetComponent<Click>().nowItem;
        Debug.Log(nowGameItem.number);
        Debug.Log(nowGameItem.status_int);
        if (nowGameItem.isequipting == true)
        {
            cheak = true;
            switch (nowGameItem.ItemType)
            {
                case ("무기"):
                    if (Weapon.GetComponent<Click>().isequipting == true)
                    GameObject.Find("Taemin").GetComponent<Player>().Str -= nowGameItem.status_int;
                    break;
                case ("갑옷"):
                    if (armo.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                    break;
                case ("방패"):
                    if (sheld.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex -= nowGameItem.status_int;
                    break;
                case ("투구"):
                    if (head.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Hp -= nowGameItem.status_int;
                    break;
            }
        }
            
        nowGameItem = Itemlist[nowGameItem.number + 1];
        nowGameItem.isequipting = cheak;
        if (nowGameItem.isequipting == true)
        {
            switch (nowGameItem.ItemType)
            {
                case ("무기"):
                    if (Weapon.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Str += nowGameItem.status_int;
                    break;
                case ("갑옷"):
                    if (armo.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex += nowGameItem.status_int;
                    break;
                case ("방패"):
                    if (sheld.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Dex += nowGameItem.status_int;
                    break;
                case ("투구"):
                    if (head.GetComponent<Click>().isequipting == true)
                        GameObject.Find("Taemin").GetComponent<Player>().Hp += nowGameItem.status_int;
                    break;
            }
        }
            
        nowimage.GetComponent<Click>().nowItem = nowGameItem;


        SetUpgradeDeiscription();
        Setdeiscription(nowGameItem);
        nowimage_2.sprite = nowGameItem.sprite;


    }

    public void DoPromoteinEqipting()
    {

    }

    #endregion

    #region
    public Animator StatusAnim; 
    public Text Str;
    public Text Dex;
    public Text Hp;
    public Text CriPer;
    public Text CriDmg;
    public Text StatusPoint;
    public GameObject StrBottn;
    public GameObject DexBottn;
    public GameObject HpBottn;

    public void OpenStatusPannel()
    {
       
        SetStatusdiscription();
        StatusAnim.SetTrigger("doShow");
        inventoryAnim.SetTrigger("doHide");
        FoodBtn.interactable = false;
        InvenBtn.interactable = false;
    }

    public void CloseStatusPannel()
    {
        Debug.Log("실해오딧응ㅁ디나");
        StatusAnim.SetTrigger("doHide");
        inventoryAnim.SetTrigger("doShow");
        FoodBtn.interactable = true;
        InvenBtn.interactable = true;
    }

    public void SetStatusdiscription()
    {
        if (GameObject.Find("Taemin").GetComponent<Player>().StatusPoint != 0)
        {
            StrBottn.SetActive(true);
            DexBottn.SetActive(true);
            HpBottn.SetActive(true);
        }
        else
        {
            StrBottn.SetActive(false);
            DexBottn.SetActive(false);
            HpBottn.SetActive(false);
        }

        Str.text = "공격력: " + GameObject.Find("Taemin").GetComponent<Player>().Str.ToString();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        Dex.text = "방어력: " + GameObject.Find("Taemin").GetComponent<Player>().Dex.ToString();
        Hp.text = "체력: " + GameObject.Find("Taemin").GetComponent<Player>().Hp.ToString();
        CriPer.text = "치명타확률: " + GameObject.Find("Taemin").GetComponent<Player>().CriticalPersent.ToString()+"%";
        CriDmg.text = "치명타데미지: " + GameObject.Find("Taemin").GetComponent<Player>().CriticalDamage.ToString()+"%";
        StatusPoint.text = "잔여 스텟포인트: " + GameObject.Find("Taemin").GetComponent<Player>().StatusPoint.ToString();
       
    }

    

    public void UseStatusStr()
    {   
        GameObject.Find("Taemin").GetComponent<Player>().Str += 2;
        GameObject.Find("Taemin").GetComponent<Player>().StatusPoint -= 1;
        SetStatusdiscription();
    }
    public void UseStatusDex()
    {   
        GameObject.Find("Taemin").GetComponent<Player>().Dex += 1;
        GameObject.Find("Taemin").GetComponent<Player>().StatusPoint -= 1;
        SetStatusdiscription();
    }

    public void UseStatusHp()
    {
        
        GameObject.Find("Taemin").GetComponent<Player>().Hp += 25;
        GameObject.Find("Taemin").GetComponent<Player>().StatusPoint -= 1;
        SetStatusdiscription();
    }

    public void LevelMadaGangsin()
    {
        if (acessory.GetComponent<Click>().nowItem == null)
        {
            return;
        }
        switch (acessory.GetComponent<Click>().nowItem.isacesoryCnt) {
            case 1:
                GameObject.Find("Taemin").GetComponent<Player>().Dex -= 5 * ((GameObject.Find("Taemin").GetComponent<LevelSilider>().Level)-1);
                GameObject.Find("Taemin").GetComponent<Player>().Dex += 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
                GameObject.Find("Taemin").GetComponent<Player>().Hp -= 50 * ((GameObject.Find("Taemin").GetComponent<LevelSilider>().Level)-1);
                GameObject.Find("Taemin").GetComponent<Player>().Hp += 50 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
                break;
            case 3:
                GameObject.Find("Taemin").GetComponent<Player>().Str -= 5 * ((GameObject.Find("Taemin").GetComponent<LevelSilider>().Level)-1);
                GameObject.Find("Taemin").GetComponent<Player>().Str += 5 * (GameObject.Find("Taemin").GetComponent<LevelSilider>().Level);
                break;
            default:
                break;

        }

        
    }
    #endregion


}
