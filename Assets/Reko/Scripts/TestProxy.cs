using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PureMVC.Patterns;

namespace Assets.Reko.Scripts
{
    public class TestProxy:Proxy
    {
        /// <summary>
        /// 这里的字段事Proxy中定义的，问题
        /// </summary>
        public new const string NAME = "TestProxy";
        public new UserInfo Data { get; set; }

        public TestProxy():base(NAME)
        {
            Data = new UserInfo();

        }

        public void LevelChange(int changes)
        {
            Data.Level += changes;
            SendNotification(UserNotifications.LevelChange, Data);

        }
    }
}
