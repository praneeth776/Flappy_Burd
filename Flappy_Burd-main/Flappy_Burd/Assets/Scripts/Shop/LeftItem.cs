using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftItem : MonoBehaviour
{
    public SpriteRenderer birdSprite;
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public static LeftItem Instance;

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

        birdSprite.sprite = options[currentOption];
    }

    public void PrevOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;

        }

        birdSprite.sprite = options[currentOption];
    }

}
