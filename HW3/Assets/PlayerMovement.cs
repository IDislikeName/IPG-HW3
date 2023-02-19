using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 move;
    Rigidbody rb;
    public float moveSpeed;
    public GameObject pistol;
    public GameObject rifle;
    bool unlocked;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        move = new Vector3(horiz,0,vert);
        float h = Input.mousePosition.x - Screen.width / 2;
        float v = Input.mousePosition.y - Screen.height / 2;
        float angle = -Mathf.Atan2(v, h) * Mathf.Rad2Deg;

        transform.GetChild(0).rotation = Quaternion.Euler(0, angle, 0);

        
        
        Camera.main.transform.position = transform.position + new Vector3(0, 15f, 0);

        if (GameManager.instance.score >= 10 && !unlocked)
        {
            unlocked = true;
            pistol.SetActive(false);
            rifle.SetActive(true);

        }
    }
    
    private void FixedUpdate()
    {
        if (!GameManager.instance.lost)
            rb.velocity = move * moveSpeed;
    }
}
