using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Reko.Scripts
{
    /// <summary>
    /// 直接用于操作显示的类，相当于view
    /// </summary>
    public class TestMediator:Mediator
    {
        public new const string NAME = "TestMeditor";
        /// <summary>
        /// UI上的text
        /// </summary>
        private Text levelText;
        /// <summary>
        /// UI上的Btn
        /// </summary>
        private Button levelUpButton;
        public TestMediator(GameObject root):base(NAME)
        {
            levelText = GameUtilis.GetComponent<Text>(root, "LevelText");
            levelUpButton = GameUtilis.GetComponent<Button>(root, "LevelUpButton");
            //绑定事件
            levelUpButton.onClick.AddListener(OnClickLevelUpButton);

        }

        /// <summary>
        /// 绑定的事件函数，发送通知
        /// </summary>
        private void OnClickLevelUpButton()
        {
            SendNotification(UserNotifications.LevelUp);
        }

        /// <summary>
        /// 设置Mediator关心的通知，或者叫做订阅的通知
        /// </summary>
        /// <returns>返回关心的通知集合</returns>
        public override IList<string> ListNotificationInterests()
        {
            IList<string> list = new List<string>();
            list.Add(UserNotifications.LevelChange);
            return list;
        }

        /// <summary>
        /// 处理接收到的通知
        /// </summary>
        /// <param name="notification"></param>
        public override void HandleNotification(INotification notification)
        {
            //判断通知的信息，并从中拿到数据，进行显示
            switch(notification.Name)
            {
                case UserNotifications.LevelChange:
                    UserInfo user = notification.Body as UserInfo;
                    levelText.text = user.Level.ToString();
                    break;
                default:
                    break;

            }
        }

    }
}
