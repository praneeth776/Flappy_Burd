using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShop2 : MonoBehaviour
{
    [SerializeField] Button _next;
    [SerializeField] Button _prev;
    [SerializeField] Button _mainMenu;
    [SerializeField] Button _select;
    // Start is called before the first frame update
    void Start()
    {
        _next.onClick.AddListener(TheBirds.Instance.Next);
        _prev.onClick.AddListener(TheBirds.Instance.Prev);
        _mainMenu.onClick.AddListener(LoadMainMenu);
        _select.onClick.AddListener(TheBirds.Instance.select);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadMainMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
    }
}
