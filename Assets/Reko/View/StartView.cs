using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartView : MonoBehaviour
{
    [SerializeField]
    private Button startButton;

    public void AddListener(UnityAction action)
    {
        startButton.onClick.AddListener(action);
    }

    /// <summary>
    /// 可以设置退出的方法，提供给Mediator使用
    /// </summary>
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
