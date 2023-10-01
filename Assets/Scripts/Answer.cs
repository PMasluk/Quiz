using System;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public Action OnSelect;

    [SerializeField]
    private Button button;
    [SerializeField]
    private GameObject correctPanel;
    [SerializeField]
    private GameObject incorrectPanel;
    [SerializeField]
    private GameObject neutralPanel;

    private void Awake()
    {
        button.onClick.AddListener(() => OnSelect?.Invoke());
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(() => OnSelect?.Invoke());
    }

    public void Restart()
    {
        neutralPanel.SetActive(true);
        incorrectPanel.SetActive(false);
        correctPanel.SetActive(false);
    }

    public void OnGoodAnswer()
    {
        neutralPanel.SetActive(false);
        incorrectPanel.SetActive(false);
        correctPanel.SetActive(true);
    }

    public void OnBadAnswer()
    {
        neutralPanel.SetActive(false);
        incorrectPanel.SetActive(true);
        correctPanel.SetActive(false);
    }
}
