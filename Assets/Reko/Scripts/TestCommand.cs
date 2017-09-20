using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace Assets.Reko.Scripts
{
    public class TestCommand:SimpleCommand
    {
        
        public new const string NAME = "TestCommand";
        public override void Execute(INotification notification)
        {
            TestProxy proxy = (TestProxy)Facade.RetrieveProxy(TestProxy.NAME);
            proxy.LevelChange(1);
        }

    }
}
