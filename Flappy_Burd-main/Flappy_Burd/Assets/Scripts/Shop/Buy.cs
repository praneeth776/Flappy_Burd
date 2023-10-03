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
    public TheBirds Birds;

    Sprite currentSprite;
    int price;


    void Start()
    {
        Birds = GameObject.FindGameObjectWithTag("Birds").GetComponent<TheBirds>();
        buyButton.onClick.AddListener(canBuy);
    }

    

    // Update is called once per frame
    public void canBuy()
    {
        

        
        if (!Birds.BirdList.Contains(MiddleItemScript.Instance.middleSprite.sprite))
        {
            if (PlayerPrefs.GetInt("Total Coins") >= int.Parse(MiddleItemScript.Instance.price.text))
            {

                Debug.Log("Item bought");

                PlayerPrefs.SetInt("Total Coins", PlayerPrefs.GetInt("Total Coins") - int.Parse(MiddleItemScript.Instance.price.text));

                _character.GetComponent<SpriteRenderer>().sprite = MiddleItemScript.Instance.middleSprite.sprite;// It changes the current birdsprite to the sprite just bought

                Birds.BirdList.Add(MiddleItemScript.Instance.middleSprite.sprite);// It saves the sprite we bought in a list in skins.

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
