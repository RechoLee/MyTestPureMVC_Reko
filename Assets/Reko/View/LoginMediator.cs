using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class LoginMediator : Mediator
{
    public new const string NAME = "LoginMediator";

    private GameObject root;

    private LoginVO loginVo;

    public LoginMediator(GameObject _root) : base(NAME)
    {
        root = _root;
        loginVo=new LoginVO();
        root.GetComponent<LoginView>().AddListener(OnClickLogin);
    }

    public void OnClickLogin()
    {
        loginVo.Id = root.GetComponent<LoginView>().ID;
        loginVo.Pwd = root.GetComponent<LoginView>().PWD;
        SendNotification(MyNotifications.CommitLogin,loginVo);
       
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case MyNotifications.LoginSuccess:
                //..
                Debug.Log("loginsuccess");
                break;
            case MyNotifications.LoginFiled:
                //..
                Debug.Log("loginfiled");
                break;
            default:
                break;
        }
    }

    public override IList<string> ListNotificationInterests()
    {
        IList<string> list =new List<string>();
        list.Add(MyNotifications.LoginSuccess);
        list.Add(MyNotifications.LoginFiled);
        return list;
    }
}