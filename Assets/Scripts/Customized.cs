using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customized : MonoBehaviour
{
    public SpriteRenderer[] parts = null;
    private void Start()
    {
        Init();
    }
    void Init()
    {
    }
    void SetParts(int i, string _name)
    {
        switch(i)
        {
            case 0:
                parts[0].sprite = MakeSprite(System.IO.Directory.GetFiles(Application.streamingAssetsPath + "/Character/Face", _name)[0]);
                break;
            case 1:
                parts[1].sprite = MakeSprite(System.IO.Directory.GetFiles(Application.streamingAssetsPath + "/Character/Hair", _name)[0]);
                break;
            case 2:
                parts[2].sprite = MakeSprite(System.IO.Directory.GetFiles(Application.streamingAssetsPath + "/Character/Beard", _name)[0]);
                break;
            case 3:
                for(int j = 0; j < Resources.LoadAll<Sprite>($"Character/Armor/{_name.Replace(".png", "")}").Length; j++)
                {
                    parts[j+3].sprite = Resources.LoadAll<Sprite>($"Character/Armor/{_name.Replace(".png", "")}")[j];
                }
                break;
            case 4:
                for (int j = 0; j < Resources.LoadAll<Sprite>($"Character/Pant/{_name.Replace(".png", "")}").Length; j++)
                {
                    parts[j + 6].sprite = Resources.LoadAll<Sprite>($"Character/Pant/{_name.Replace(".png", "")}")[j];
                }
                break;
            case 5:
                parts[8].sprite = Resources.Load<Sprite>($"Character/Weapons/{_name.Replace(".png", "")}");
                break;
            case 6:
                parts[9].sprite = Resources.Load<Sprite>($"Character/Weapons/{_name.Replace(".png", "")}");
                break;
        }
    }
    public Sprite MakeSprite(string filePath)
    {
        byte[] pngBytes = System.IO.File.ReadAllBytes(filePath);
        Texture2D tex = new(2, 2)
        {
            filterMode = FilterMode.Point
        };
        tex.LoadImage(pngBytes);

        Sprite fromTex = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0f), 100);
        return fromTex;
    }
    public void RandomParts(int i)
    {
        System.IO.DirectoryInfo directoryInfo;
        switch (i)
        {
            case 0:
                directoryInfo = new(Application.streamingAssetsPath + "/Character/Face");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
            case 1:
                directoryInfo = new(Application.streamingAssetsPath + "/Character/Hair");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
            case 2:
                directoryInfo = new(Application.streamingAssetsPath + "/Character/Beard");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
            case 3:
                directoryInfo = new(Application.dataPath + "/Resources/Character/Armor");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
            case 4:
                directoryInfo = new(Application.dataPath + "/Resources/Character/Pant");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
            case 5:
                directoryInfo = new(Application.dataPath + "/Resources/Character/Weapons");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
            case 6:
                directoryInfo = new(Application.dataPath + "/Resources/Character/Weapons");
                SetParts(i, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories)[Random.Range(0, directoryInfo.GetFiles("*.png", System.IO.SearchOption.AllDirectories).Length)].Name);
                break;
        }
    }
}
