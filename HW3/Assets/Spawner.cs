using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sp()
    {
        float ranx = Random.Range(-20, 24);
        float ranz = Random.Range(-21, 23);
        RaycastHit m_Hit;
        if (Physics.BoxCast(new Vector3(ranx, 1, ranz), transform.localScale, transform.forward, out m_Hit)){
            if (m_Hit.collider.CompareTag("Walls"))
            {
                Sp();
            }
            else
            {
                GameObject e = Instantiate(enemy);
                e.transform.position = new Vector3(ranx, 1, ranz);
            }
        }
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3f);
        Sp();
        if(GameManager.instance.lost)
            StartCoroutine(Spawn());
    }
}
