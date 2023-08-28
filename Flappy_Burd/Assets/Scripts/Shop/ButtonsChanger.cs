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
        previousButton.onClick.AddListener(MiddleItemScript.Instance.PrevOption);
        previousButton.onClick.AddListener(LeftItem.Instance.PrevOption);
        previousButton.onClick.AddListener(RightItem.Instance.PrevOption);
        nextButton.onClick.AddListener(ShopMenu.Instance.NextOption);
        nextButton.onClick.AddListener(MiddleItemScript.Instance.NextOption);
        nextButton.onClick.AddListener(LeftItem.Instance.NextOption);
        nextButton.onClick.AddListener(RightItem.Instance.NextOption);
    }

    
}
