using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public FloatingTextManager floatingTextManager;
    
    private void Awake() 
    {
        if (GameManager.instance != null) 
        {
            Destroy(gameObject);
            return;
        }
        PlayerPrefs.DeleteAll();
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
        //DontDestroyOnLoad(floatingTextManager.gameObject);
    }

    //resources

    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrice;
    public List<int> xpTable;


    //refrences 
    public Player player;

    

    public int gold;
    public int experience;
    public int heart;


    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        if (msg != null)
        {

            floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
        }
    }






    //SaveState
    /*INT skin
     *INT gold
     *INT exp
     *INT weaponlevel
     *INT heart
     */
    public void SaveState() 
    {
        
        string s = "";
        s += "0"+"|";
        s += gold.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0" + "|";
        s += heart.ToString();
        PlayerPrefs.SetString("SaveState",s);
        Debug.Log("Saved");
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
            return;
        string[] data = PlayerPrefs.GetString("SaveState").Split('|');
        //skin
        gold = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        //weapon
        heart = int.Parse(data[4]);

        Debug.Log("Loaded");
    }


}
