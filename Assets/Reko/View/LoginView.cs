using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LoginView : MonoBehaviour
{
    [SerializeField]
    private Button loginBtn;

    [SerializeField]
    private InputField idField;

    [SerializeField]
    private InputField pwdField;

    public string ID
    {
        get { return idField.text; }
    }

    public string PWD
    {
        get { return pwdField.text; }
        
    }

    public void AddListener(UnityAction action)
    {
        loginBtn.onClick.AddListener(action);
    }

    public void Closed(bool flag)
    {
        this.gameObject.SetActive(flag);
    }

    public void InitView()
    {
        this.gameObject.SetActive(true);
    }

    void Start()
    {
        AppFacade.GetInstance().RegisterMediator(new LoginMediator(gameObject));
    }
}
