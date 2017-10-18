using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using PureMVC.Patterns;
using UnityEngine;

public class UserLoginProxy : Proxy
{
    public new const string NAME = "UserLoginProxy";

    public UserLoginProxy() : base(NAME)
    {
        
    }

    public void LoginToData(string id, string pwd)
    {
        if (UserTable.IsExit(id, pwd))
        {
            SendNotification(MyNotifications.LoginSuccess);
        }
        else
        {
            SendNotification(MyNotifications.LoginFiled);
        }
       
    }

}