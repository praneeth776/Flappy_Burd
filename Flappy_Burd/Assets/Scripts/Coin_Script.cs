using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Coin_Script : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone = -30;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Coin Deleted");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addCoin(1);
            Destroy(gameObject);
        }
    }
}
