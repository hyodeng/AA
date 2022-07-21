using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    //bool open = false;

    
    

    
    
    public void StagefirstSceneChange()
    {
        SceneManager.LoadScene("Grass_Scene");
    }
    public void Stage2SceneChange()
    {
        
        SceneManager.LoadScene("Desert_Scene");
    }
    public void Stage3SceneChange()
    {
        SceneManager.LoadScene("Boss_Scene");
    }
    public void stageChange()
    {
        SceneManager.LoadScene("Stage_Scene");
    }
    public void Stage1SceneChange()
    {
        SceneManager.LoadScene("Grass_Scene");
    }

}

