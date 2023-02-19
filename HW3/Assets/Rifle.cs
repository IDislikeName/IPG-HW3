using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
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
        StartCoroutine(TripleFire());
    }
    IEnumerator TripleFire()
    {
        yield return new WaitForSeconds(0.3f);
        GameObject b = Instantiate(bullet);
        b.transform.rotation = transform.GetChild(0).rotation;
        b.transform.position = bulletSpawn.position;
        yield return new WaitForSeconds(0.3f);
        GameObject b2 = Instantiate(bullet);
        b2.transform.rotation = transform.GetChild(0).rotation;
        b2.transform.position = bulletSpawn.position;
        yield return new WaitForSeconds(0.3f);
        GameObject b3 = Instantiate(bullet);
        b3.transform.rotation = transform.GetChild(0).rotation;
        b3.transform.position = bulletSpawn.position;
    }
}
