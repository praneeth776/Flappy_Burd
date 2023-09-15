using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class TheBirds : MonoBehaviour
{
    public List<Sprite> BirdList = new List<Sprite>();
    public GameObject _character;
    
    private int BigBirdIndex ;
    private int LeftBirdIndex ;
    private int RightBirdIndex ;
    

    public SpriteRenderer BIGBird;
    public SpriteRenderer LEFTBird;
    public SpriteRenderer RIGHTBird;

    public static TheBirds Instance;
    


    private void Start()
    {
        if (BirdList.Count < 3)
        {
            BigBirdIndex = 0;
            if (BirdList.Count == 2)
            {
                LeftBirdIndex = 1;
                RightBirdIndex = 1;
            }
            else
            {
                LeftBirdIndex = 0;
                RightBirdIndex = 0;
            }
        }

        else
        {
            BigBirdIndex = 1;
            LeftBirdIndex = 0;
            RightBirdIndex = 0;
        }

        BIGBird.sprite = BirdList[BigBirdIndex];
        LEFTBird.sprite = BirdList[LeftBirdIndex];
        RIGHTBird.sprite = BirdList[RightBirdIndex];
    }

    private void Awake()
    {
        Instance = this;

    }

    public void Next()
    {
        BigBirdIndex++ ;
        Debug.Log("BirdList length: " + BirdList.Count.ToString());
        Debug.Log("BigBirdIndex before: " + BigBirdIndex.ToString());
        if (BigBirdIndex >= BirdList.Count) { BigBirdIndex = 0; }
        Debug.Log("BigBirdIndex after: " + BigBirdIndex.ToString());
        LeftBirdIndex++;
        if (LeftBirdIndex >= BirdList.Count) { LeftBirdIndex = 0; }
        RightBirdIndex++;
        if (RightBirdIndex >= BirdList.Count) { RightBirdIndex = 0; } 

        BIGBird.sprite = BirdList[BigBirdIndex];
        LEFTBird.sprite = BirdList[LeftBirdIndex];
        RIGHTBird.sprite = BirdList[RightBirdIndex];


        
    }

    public void Prev()
    {
        BigBirdIndex-- ;
        if (BigBirdIndex <0) { BigBirdIndex = BirdList.Count - 1; }
        LeftBirdIndex-- ;
        if (LeftBirdIndex < 0) { LeftBirdIndex = BirdList.Count - 1; }
        RightBirdIndex-- ;
        if (RightBirdIndex <0) { RightBirdIndex = BirdList.Count - 1; }

        BIGBird.sprite = BirdList[BigBirdIndex];
        LEFTBird.sprite = BirdList[LeftBirdIndex];
        RIGHTBird.sprite = BirdList[RightBirdIndex];

        
    }

    public void select()
    {
        //PrefabAssetType prefabPath = ()AssetDatabase.LoadAssetAtPath("Assets/TheBirdSprite.prefab", typeof(PrefabAssetType));
        _character.GetComponent<SpriteRenderer>().sprite = BirdList[BigBirdIndex];
        //AssetDatabase.OpenAsset(prefabPath);
        
    }

    


}
