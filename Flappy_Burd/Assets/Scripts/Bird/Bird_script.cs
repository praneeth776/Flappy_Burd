using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public int velocity;
    public UIGameOver logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<UIGameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            myRigidbody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logic != null)
        {
            logic.GameOver();
        }
    }
}
