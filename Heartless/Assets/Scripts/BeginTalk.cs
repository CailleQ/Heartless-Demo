using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginTalk : NPCTalk
{
    private float lastInteractionTime; // 上次交互时间
    private float interactionCooldown = 4f; // 交互冷却时间

    protected bool told;
    string phare = "你好 Heartless,也许今天你能找回你的❤ ,不如现在往地牢深处看看怎样";
    string phare2 = "我找不到飞机和胖子的像素图所以没做捏，我在文件夹里留了gift.txt，那应该能帮到你";
    protected override void onTalk()
    {
        if (!told&& GameManager.instance.heart != 1) 
        {
            GameManager.instance.ShowText(phare, 20, Color.yellow, this.transform.position, Vector3.up * 15, 3.5f);
            told = true;
            Debug.Log(GameManager.instance.heart);
            lastInteractionTime = Time.time;
        }
        if (GameManager.instance.heart ==1 && Time.time - lastInteractionTime > interactionCooldown) 
        {
            GameManager.instance.ShowText(phare2, 20, Color.yellow, this.transform.position, Vector3.up * 15, 3.5f);
            lastInteractionTime = Time.time;
        }
    }
}
