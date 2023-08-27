using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsChanger : MonoBehaviour
{
    [SerializeField] Button previousButton;
    [SerializeField] Button nextButton;
    void Start()
    {
        previousButton.onClick.AddListener(ShopMenu.Instance.PrevOption);
        nextButton.onClick.AddListener(ShopMenu.Instance.NextOption);
    }

    
}
