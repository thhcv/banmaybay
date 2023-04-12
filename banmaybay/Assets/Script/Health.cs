using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Score scr;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) 
        {
            scr.score++;
            Destroy(gameObject);
        }
    }
}
