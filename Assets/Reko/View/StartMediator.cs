using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMediator:Mediator
{
    public new const string NAME = "StartMediator";

    private GameObject root;

    public StartMediator(GameObject _root) : base(NAME)
    {
        this.root = _root;
        _root.GetComponent<StartView>().AddListener(
            ()=>SendNotification(MyNotifications.START)
            );
    }

    public override IList<string> ListNotificationInterests()
    {
        IList<string> list = new List<string>();
        list.Add(MyNotifications.STARTUP);
        return list;
    }

    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case MyNotifications.STARTUP:
                SceneManager.LoadScene(1);
                break;
            default:
                break;
        }
    }
}
