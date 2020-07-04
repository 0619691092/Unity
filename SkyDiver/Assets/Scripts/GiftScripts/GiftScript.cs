using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftScript : MonoBehaviour
{
    private float camaraY; 
    // Start is called before the first frame update
    void Awake()
    {
        camaraY = Camera.main.transform.position.y + 10f;
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
        temp.y += 1.5f * Time.deltaTime;
        transform.position = temp;
    }

    private void Deactivate()
    {
        if (transform.position.y > camaraY)
        {
            gameObject.SetActive(false);
        }
    }
}
