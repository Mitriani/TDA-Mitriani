using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 50f;
    private float contador = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        contador += Time.deltaTime;
        if (contador >= 2)
        {
            Destroy(gameObject);
            contador = 0;
        }
    }

    private void OnCollisionEnter(Collision wall)
    {
        if (wall.gameObject.CompareTag("Wall"))
        {
            wall.gameObject.SetActive(false);
        }
    }
}
