using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField] private GameObject[] walls;
    [SerializeField] float contador = 5f;
    void Start()
    {

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RecorrerPared();
    }

    void RecorrerPared()
    {
        for (int i = 0; i < walls.Length; i++)
        {
            contador -= Time.deltaTime;
            if (contador <= 0)
            {
                contador = 5f;
                if (contador >= 4.9f)
                {
                    walls[i].SetActive(true);
                }
            }
        }
    }
}
