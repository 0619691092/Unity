using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRightScript : MonoBehaviour
{
    private float camaraY;
    private float camaraX;
    // Start is called before the first frame update
    void Awake()
    {
        camaraY = Camera.main.transform.position.y + 10f;
        camaraX = Camera.main.transform.position.x - 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Deactivate();
    }

    private void Move()
    {
        Vector3 temp = transform.position;
        temp.y = transform.position.y;
        temp.x = transform.position.x;
        temp.y += 0.3f * Time.deltaTime;
        temp.x -= 2f * Time.deltaTime;
        transform.position = temp;
    }

    private void Deactivate()
    {
        if (transform.position.y > camaraY || transform.position.x < camaraX)
        {
            gameObject.SetActive(false);
        }
    }
}
