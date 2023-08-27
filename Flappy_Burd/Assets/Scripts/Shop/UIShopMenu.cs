using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class UIShopMenu : MonoBehaviour
{
    [SerializeField] Button _mainMenu;
    [SerializeField] GameObject _character;
    // Start is called before the first frame update
    void Start()
    {
        
        _mainMenu.onClick.AddListener(StartMainMenu);
    }

    private void StartMainMenu()
    {
        PrefabUtility.SaveAsPrefabAsset(_character,"Assets/TheBirdSprite.prefab");
        ScenesManager.Instance.LoadMainMenu();
    }

}