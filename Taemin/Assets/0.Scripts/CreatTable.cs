using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatTable : MonoBehaviour
{
    public Animator CreatTableAnim;

    public int Page = 0;

    public Image CreatItem;
    public Sprite[] CreatItemList;

    public Sprite[] CreatFirstItemMeterial;

    public Sprite[] CreatSecondItemMeterial;

    public Sprite[] CreatThirdItemMeterial;

    public Sprite[] CreatForthItemMeterial;

    public Image[] MaterialsList;

    public Text[] MaTerialsTextList;

    public bool isOpen = false;

    public Item item;

    public void Creat()
    {
        Debug.Log("들어왓음");
        int a;
        int b;
        b = 22 + Page;
        a = 26 + Page * 3;

        bool haveall = true;
        for (int y = 0; y < 4; y++)
        {
            if (MaTerialsTextList[y].text != "1/1")
            {
                haveall = false;
            }
        }
        Debug.Log("검사1실행");
        bool kanitsem = false;
        //아이템창이 한칸도없다면 리턴
        for (int i = 0; i < 15; i++)
        {
            if (!item.CheakInventorylist[i])
            {
                kanitsem = true;
            }

        }
        Debug.Log("제작실행되엇습니다");
        if (haveall && kanitsem)
        {
            item.GetItem(item.Itemlist[b]);

            for (int y = 0; y < 3; y++)
            {

                for (int i = 0; i < 15; i++)
                {
                    if (item.InventoryItemlist[i].GetComponent<Click>().nowItem != null)
                    {

                        if (item.InventoryItemlist[i].GetComponent<Click>().nowItem.number == a + y)
                        {
                            MaTerialsTextList[y].text = "0/1";
                            item.InventoryItemlist[i].GetComponent<Click>().nowItem = null;
                            item.Inventorylist[i].color = new Color(255, 255, 255, 0);
                            break;
                        }

                    }

                }
            }
            for (int i = 0; i < 15; i++)
            {
                if (item.InventoryItemlist[i].GetComponent<Click>().nowItem != null)
                {
                    if (item.InventoryItemlist[i].GetComponent<Click>().nowItem.number == 38)
                    {
                        MaTerialsTextList[3].text = "0/1";
                        item.InventoryItemlist[i].GetComponent<Click>().nowItem = null;
                        item.Inventorylist[i].color = new Color(255, 255, 255, 0);
                        break;
                    }

                }


            }
        }
    }

    private void Start()
    {
        item = GameObject.Find("ItemManager").GetComponent<Item>();
       
    }

    public void OpenCreatTable()
    {
        if (!isOpen)
        {
            SetDiscription();
            CreatTableAnim.SetTrigger("doShow");
            isOpen = true;
        }

        else
        {
            CreatTableAnim.SetTrigger("doHide");
            isOpen = false;
        }   
    }

    public void ColseCreatTable()
    {
        CreatTableAnim.SetTrigger("doHide");
        isOpen = false;
    }

    public void add()
    {
        SetDiscription();
        if (Page < 3)
        Page += 1;
    }

    public void Subsubtract()
    {
        SetDiscription();
        if (Page > 0)
        Page -= 1;
    }
    
    public void SetDiscription()
    {
        CreatItem.sprite = CreatItemList[Page];
        switch (Page)
        {
            case 0:
                for(int i=0; i<4; i++)
                {
                    CheakInventory(26);
                    MaterialsList[i].sprite = CreatFirstItemMeterial[i];
                }
               
                break;

            case 1:
                for (int i = 0; i < 4; i++)
                {
                    CheakInventory(29);
                    MaterialsList[i].sprite = CreatSecondItemMeterial[i];
                }

                break;

            case 2:
                for (int i = 0; i < 4; i++)
                {
                    CheakInventory(32);
                    MaterialsList[i].sprite = CreatThirdItemMeterial[i];
                }

                break;

            case 3:
                for (int i = 0; i < 4; i++)
                {
                    CheakInventory(35);
                    MaterialsList[i].sprite = CreatForthItemMeterial[i];
                }

                break;
        }

    }

    public void CheakInventory(int a)
    {
        
        for (int y = 0; y < 3; y++)
        {

            for (int i = 0; i < 15; i++)
            {
                if(item.InventoryItemlist[i].GetComponent<Click>().nowItem != null)
                {
                    
                    if (item.InventoryItemlist[i].GetComponent<Click>().nowItem.number == a + y)
                    {
             
                        MaTerialsTextList[y].text = "1/1";
                        break;
                    }
                    else
                    {
                        MaTerialsTextList[y].text = "0/1";
                    }
                }
                
            }
        }
        for (int i = 0; i < 15; i++)
        {
            if (item.InventoryItemlist[i].GetComponent<Click>().nowItem != null)
            {
                if (item.InventoryItemlist[i].GetComponent<Click>().nowItem.number == 38)
                {
                    MaTerialsTextList[3].text = "1/1";
                    break;
                }
                else
                {
                    MaTerialsTextList[3].text = "0/1";
                }
            }
                
                
        }
    }

    public void why()
    {

    }
}
