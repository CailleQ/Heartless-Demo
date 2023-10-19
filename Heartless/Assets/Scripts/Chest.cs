using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public string code = "";

    protected override void OnCollect() 
    {
        if (!collected) 
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("某人给你留了礼物在这，好像是一 "+code, 20, Color.yellow, transform.position, Vector3.up * 15, 3.0f);
            
            Debug.Log("某人给你留了礼物在这，好像是一瓶幻想药 : KPUNSJQM230C1I32AXUG10000 ");
        }
    }
}
