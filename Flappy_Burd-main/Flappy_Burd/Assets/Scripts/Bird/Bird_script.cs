using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public int velocity;
    public LogicScript logic;
    public static int spacecount = 0;
    
    

    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spacecount == 0) { Time.timeScale = 1; }
            
            spacecount++;
            myRigidbody.velocity = Vector2.up * velocity;
        }

        if(myRigidbody.position.y < -30) 
        {
            Time.timeScale = 0;
            logic.GameOver();
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Time.timeScale = 0;
        logic.GameOver();
    }
}
