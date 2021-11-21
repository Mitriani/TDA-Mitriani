using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject[] cameras;
    [SerializeField] private List<GameObject> camaras;
    [SerializeField] private int indexCamara = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            indexCamara++;
            if (indexCamara == camaras.Count)
            {
                indexCamara = 0;
            }
            SwitchCam(indexCamara);
        }
    }

    private void SwitchCam(int index)
    {
        foreach (var camara in camaras)
        {
            camara.SetActive(false);
        }
        cameras[index].SetActive(true);
    }
}
