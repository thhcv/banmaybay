using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject Shoot;
    public Transform Shootspawn;
    private float timer;
    public float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > time)
        {
            timer = 0;
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(Shoot,Shootspawn.position,Quaternion.identity);
    }
}