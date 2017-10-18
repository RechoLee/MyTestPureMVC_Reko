using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class LoginCommand : SimpleCommand
{
    public new const string NAME = "LoginCommand";

    public override void Execute(INotification notification)
    {
        LoginVO loginVo =new LoginVO();
        loginVo = notification.Body as LoginVO;
        UserLoginProxy userLoginProxy = (UserLoginProxy) AppFacade.GetInstance().RetrieveProxy(UserLoginProxy.NAME);
        userLoginProxy.LoginToData(loginVo.Id,loginVo.Pwd);
    }
}