using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class UIShopMenu : MonoBehaviour
{
    [SerializeField] Button _mainMenu;
    [SerializeField] GameObject _character;
    [SerializeField] Text Coins;
    // Start is called before the first frame update
    void Start()
    {
        
        _mainMenu.onClick.AddListener(StartMainMenu);
    }

    private void Update()
    {
        Coins.text = PlayerPrefs.GetInt("Total Coins", 0).ToString();
    }

    private void StartMainMenu()
    {
        
        ScenesManager.Instance.LoadMainMenu();
    }

}
