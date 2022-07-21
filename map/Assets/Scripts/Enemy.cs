using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public static bool open = false;
    private void Start()
    {
        Invoke("die", 3.0f);
        

    }
    void die()
    {
        Destroy(gameObject);
        stageChange();
        open = true;
    }
    public void stageChange()
    {
        SceneManager.LoadScene("Stage_Scene");
        
    }
}
