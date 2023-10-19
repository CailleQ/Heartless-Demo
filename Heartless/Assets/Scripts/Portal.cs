using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{
    public string sceneName = "Dungeon1";
    protected override void onCollide(Collider2D coll) 
    {
        if (coll.name == "Heartless") 
        {
            GameManager.instance.SaveState();
            SceneManager.LoadScene(sceneName);
        }
    }
}
