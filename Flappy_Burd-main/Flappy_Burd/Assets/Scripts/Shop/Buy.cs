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
    List<Sprite> list = TheBirds.Instance.BirdList;

    Sprite currentSprite;
    int price;


    void Start()
    {
        buyButton.onClick.AddListener(canBuy);
    }

    

    // Update is called once per frame
    public void canBuy()
    {
        

        
        if (!list.Contains(MiddleItemScript.Instance.middleSprite.sprite))
        {
            if (PlayerPrefs.GetInt("Total Coins") >= int.Parse(MiddleItemScript.Instance.price.text))
            {

                Debug.Log("Item bought");

                PlayerPrefs.SetInt("Total Coins", PlayerPrefs.GetInt("Total Coins") - int.Parse(MiddleItemScript.Instance.price.text));

                _character.GetComponent<SpriteRenderer>().sprite = MiddleItemScript.Instance.middleSprite.sprite;// It changes the current birdsprite to the sprite just bought

                TheBirds.Add(MiddleItemScript.Instance.middleSprite.sprite);// It saves the sprite we bought in a list in skins.

                Debug.Log("Saved Birds : " + TheBirds.Instance.BirdList.Count);
            }

            else
            {
                Debug.Log("Insufficient coins");
            }

        }

        else
        {
            Debug.Log("Item already bought");
        }

    }
}
