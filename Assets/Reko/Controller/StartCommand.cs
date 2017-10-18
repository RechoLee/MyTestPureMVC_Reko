using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class StartCommand:SimpleCommand
{
    public override void Execute(INotification notification)
    {
        SendNotification(MyNotifications.STARTUP);
    }
}
