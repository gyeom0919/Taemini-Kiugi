using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSilider : MonoBehaviour
{
    
    public int Exp = 0;
    public int Level = 1;
    public int MaxExp = 50;
    float SliderPer;
    public Slider ExpSlider;
    public Text LevelText;
    public ParticleSystem LevelUp;
    public Text LevelTextSub;

    void Start()
    {
        
    }


    private void OnMouseDown()
    {
        if(GameManager.GmisLive)
        {
            Exp += (GameManager.foodExp) * GameObject.Find("Taemin").GetComponent<Player>().GetExp;
            Debug.Log(Exp);
        }
        
    }

    void Update()
    {
        SliderPer = (float)Exp / (float)MaxExp;
        ExpSlider.value = SliderPer;
        
        if (Exp >= MaxExp)
        {
            GameObject.Find("ItemManager").GetComponent<Item>().LevelMadaGangsin();
            GameObject.Find("Taemin").GetComponent<Player>().StatusPoint += 1;
            Exp -= MaxExp;
            Level += 1;
            
            LevelText.text = Level + "Lv";
            LevelUp.Play();
            MaxExp = Level * 50;
        }
       
            
        
       


    }

    
}
