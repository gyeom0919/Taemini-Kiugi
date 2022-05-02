using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public int num;
    Image img;
    public bool isClick ;
    public Sprite clickimage;
    public Sprite clickimage_2;
    public GameItem nowItem = null;
    public Image childrenImg;
    public bool isequipt;
    public bool isequipting = false;

    private void Start()
    {
        isClick = false;
        img = GetComponent<Image>();
    }
    private void OnMouseDown()
    {
        if (isClick)
        {
            //아이템클릭해제

            GameObject.Find("ItemManager").GetComponent<Item>().nowGameItem = null;
            isClick = false;
            img.sprite = null;
            img.color = new Color(0.3058824f, 0.2901961f, 0.3058824f, 1f);
            GameObject.Find("ItemManager").GetComponent<Item>().Deletedeiscription();
        }
        else
        {
            if (GameObject.Find("ItemManager").GetComponent<Item>().lastClick != null)
                GameObject.Find("ItemManager").GetComponent<Item>().lastClick.color = new Color(255, 255, 255, 0);
            GameObject.Find("ItemManager").GetComponent<Item>().lastClick = GetComponent<Image>();

            isClick = true;
            if (!isequipt)
            {
                img.sprite = clickimage;
            }
            else
            {
                if (isequipting)
                {
                    img.sprite = clickimage;
                }
                else
                {
                    img.sprite = clickimage_2;
                }
            }
            img.color = new Color(255, 255, 255, 255);
            GameObject.Find("ItemManager").GetComponent<Item>().nowGameItem = nowItem;
            GameObject.Find("ItemManager").GetComponent<Item>().nowimage = GetComponent<Image>();
            GameObject.Find("ItemManager").GetComponent<Item>().nowimage_2 = childrenImg;


            if (nowItem == null)
            {
                GameObject.Find("ItemManager").GetComponent<Item>().Deletedeiscription();
            }
            else
            {
                GameObject.Find("ItemManager").GetComponent<Item>().Setdeiscription(this.nowItem);
            }

        }
        
       
    }
    public void Delite()
    {
        img.sprite = null;
        img.color = new Color(0.3058824f, 0.2901961f, 0.3058824f, 1f);
    }
}
