using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject menuCanvas;
    [SerializeField]
    private GameObject gameCanvas;
    [SerializeField]
    private GameObject nick;

    public GameObject Nick => nick;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            menuCanvas.SetActive(false);
            gameCanvas.SetActive(true);
        }
    }
}
