using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace Assets.Reko.Scripts
{
    /// <summary>
    /// 命令，相当于control
    /// </summary>
    public class TestCommand:SimpleCommand
    {
        
        public new const string NAME = "TestCommand";
        /// <summary>
        /// 接收通知，并执行命令
        /// </summary>
        /// <param name="notification">接收通知</param>
        public override void Execute(INotification notification)
        {
            //检索出注册的proxy  然后进行操作
            TestProxy proxy = (TestProxy)Facade.RetrieveProxy(TestProxy.NAME);
            proxy.LevelChange(1);
        }

    }
}
