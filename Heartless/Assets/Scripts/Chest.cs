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
            GameManager.instance.ShowText("ĳ�˸��������������⣬������һ "+code, 20, Color.yellow, transform.position, Vector3.up * 15, 3.0f);
            
            Debug.Log("ĳ�˸��������������⣬������һƿ����ҩ : KPUNSJQM230C1I32AXUG10000 ");
        }
    }
}
