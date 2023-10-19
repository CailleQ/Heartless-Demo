using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LQTalk : NPCTalk
{
    private float lastInteractionTime; // 上次交互时间
    private float interactionCooldown = 4f; // 交互冷却时间

    string phare = "我是水基佬,别揍我我是被抓来打工的,快去找亚历山大拿回你的❤吧";
    protected override void onTalk()
    {
        if (Time.time - lastInteractionTime > interactionCooldown)
        {

            GameManager.instance.ShowText(phare, 20, Color.yellow, this.transform.position, Vector3.up * 15, 3.5f);
            
            Debug.Log(phare);
            lastInteractionTime = Time.time;
        }
    }
}
