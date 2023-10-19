using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexTalck : NPCTalk
{
    private float lastInteractionTime; // 上次交互时间
    private float interactionCooldown = 4f; // 交互冷却时间


    protected bool told;
    string phare = "祝你生日快乐,有人拜托我在时间尽头找回了你的❤,别再弄丢了";

    string phare2 = "快回去吧，某人还有话要跟你讲，再见";
    protected override void onTalk()
    {
        if (!told)
        {
            GameManager.instance.ShowText(phare, 20, Color.yellow, this.transform.position, Vector3.up * 15, 3.5f);
            told = true;
            GameManager.instance.heart = 1;
            lastInteractionTime = Time.time;
            Debug.Log(GameManager.instance.heart);
        }
        if (Time.time - lastInteractionTime > interactionCooldown)
        {
            GameManager.instance.ShowText(phare2, 20, Color.yellow, this.transform.position, Vector3.up * 15, 3.5f);

            lastInteractionTime = Time.time;
        }
    }
}
