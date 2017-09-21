using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PureMVC.Patterns;

namespace Assets.Reko.Scripts
{
    /// <summary>
    /// 负责处理处理元数据的操作类，类似Model
    /// </summary>
    public class TestProxy:Proxy
    {
        /// <summary>
        /// 这里的字段事Proxy中定义的，问题
        /// </summary>
        public new const string NAME = "TestProxy";
        /// <summary>
        /// 封装的数据
        /// </summary>
        public new UserInfo Data { get; set; }

        public TestProxy():base(NAME)
        {
            Data = new UserInfo();

        }

        /// <summary>
        /// 供control层调用的处理方法
        /// </summary>
        /// <param name="changes"></param>
        public void LevelChange(int changes)
        {
            Data.Level += changes;
            //发送通知
            SendNotification(UserNotifications.LevelChange, Data);

        }
    }
}
