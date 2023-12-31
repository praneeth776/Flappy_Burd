using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleItemScript : MonoBehaviour
{
    public SpriteRenderer middleSprite;
    public List<Sprite> options = new List<Sprite>();
    public Text price;
    public List<string> prices = new List<string>();//[2,3,Sprite bought,5]


    private int currentOption = 0;

    public static MiddleItemScript Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void NextOption()
    {
        Debug.Log(options);
        currentOption++;

        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        middleSprite.sprite = options[currentOption];
        price.text = prices[currentOption];
    }

    public void PrevOption()
    {
        Debug.Log(options);
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;

        }

        middleSprite.sprite = options[currentOption];
        price.text = prices[currentOption];
    }
}
