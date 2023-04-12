using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Score gamemanager;
    private bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        if (health <= 0 && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
        }
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
       }
       if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemie"))
        {
            gamemanager.game();
            collision.gameObject.GetComponent<Health>().health -= 1;
            Destroy(gameObject);
        }
    }
}
