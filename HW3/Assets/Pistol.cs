using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public GameObject bullet;
    public Transform bulletSpawn;
    // Start is called before the first frame update
    public override void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }
    public override void Fire()
    {
        GameObject b = Instantiate(bullet);
        b.transform.rotation = transform.GetChild(0).rotation;
        b.transform.position = bulletSpawn.position;
    }
}
