using JetBrains.Annotations;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class AppFacade : Facade, IFacade
{
    private static AppFacade instance=null;

    public AppFacade()
    {
        RegisterProxy(new UserLoginProxy());
    }
    
    public static AppFacade GetInstance()
    {
        if(instance==null)
            instance=new AppFacade();
        return instance;
    }

    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(MyNotifications.START,typeof(StartCommand));
        RegisterCommand(MyNotifications.CommitLogin,typeof(LoginCommand));
    }

    

    public void StartUp(GameObject root)
    {
        RegisterMediator(new StartMediator(root));
    }
}