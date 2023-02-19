using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float fireCD = 1f;
    float currentCD = 0f;
    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentCD <= 0)
        {
            currentCD = fireCD;
            Fire();
        }
        currentCD -= Time.deltaTime;
        currentCD = Mathf.Max(0, currentCD);
    }
    public virtual void Fire()
    {

    }
}
