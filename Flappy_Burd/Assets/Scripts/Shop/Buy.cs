using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;


public class Buy : MonoBehaviour
{
    [SerializeField] Button buyButton;
    [SerializeField] GameObject _character;
    void Start()
    {
        buyButton.onClick.AddListener(canBuy);
    }

    // Update is called once per frame
    public void canBuy()
    {
        if (PlayerPrefs.GetInt("Total Coins") >= int.Parse(MiddleItemScript.Instance.price.text))
        {
            Debug.Log("Item bought");
            PlayerPrefs.SetInt("Total Coins", PlayerPrefs.GetInt("Total Coins") - int.Parse(MiddleItemScript.Instance.price.text));
            PrefabUtility.SaveAsPrefabAsset(_character, "Assets/TheBirdSprite.prefab");
        }
    }
}
