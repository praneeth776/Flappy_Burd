using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _newGame;
    [SerializeField] Button _shop;
    [SerializeField] Button _quit;
    [SerializeField] Button _skins;
    // Start is called before the first frame update
    void Start()
    {
        _newGame.onClick.AddListener(StartNewGame);
        _shop.onClick.AddListener(StartShop);
        _quit.onClick.AddListener(Exit);
        _skins.onClick.AddListener(StartSkins);
    }

    private void StartNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
        Time.timeScale = 1;
    }

    private void StartShop()
    {
        ScenesManager.Instance.LoadShop();
    }

    private void Exit()
    {
        Application.Quit();
    }

    private void StartSkins()
    {
        ScenesManager.Instance.LoadSkins();
    }
}
