using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    private float playerSpeed = 5;
    private float sensibilidad = 4;
    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovement();
        Disparo();
    }

    void PlayerMovement()
    {
        float vMov = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, vMov) * playerSpeed * Time.deltaTime);

        float hRot = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, hRot, 0) * sensibilidad);
    }

    void Disparo()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
