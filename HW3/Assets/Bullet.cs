using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enemy;
public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Die());
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.right * 10f;
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyBehavior>().TakeDamage(1);
            Destroy(gameObject);
        }
        if (other.CompareTag("Walls"))
            Destroy(gameObject);
    }
}
