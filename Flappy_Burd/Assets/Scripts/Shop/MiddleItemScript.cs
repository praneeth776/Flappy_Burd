using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleItemScript : MonoBehaviour
{
    public SpriteRenderer middleSprite;
    public List<Sprite> options = new List<Sprite>();
    public Text price;
    public List<string> prices = new List<string>();


    private int currentOption = 0;

    public static MiddleItemScript Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void NextOption()
    {
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
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;

        }

        middleSprite.sprite = options[currentOption];
        price.text = prices[currentOption];
    }
}
