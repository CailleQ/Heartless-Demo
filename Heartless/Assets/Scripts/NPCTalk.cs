using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : Collidable
{
    protected override void onCollide(Collider2D coll)
    {
        if (coll.name == "Heartless")
            onTalk();
    }
    protected virtual void onTalk()
    {
        Debug.Log("NowTalk");
    }
}
