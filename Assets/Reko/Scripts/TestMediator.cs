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
    public class TestMediator:Mediator
    {
        public new const string NAME = "TestMeditor";
        private Text levelText;
        private Button levelUpButton;
        public TestMediator(GameObject root):base(NAME)
        {
            levelText = GameUtilis.GetComponent<Text>(root, "LevelText");
            levelUpButton = GameUtilis.GetComponent<Button>(root, "LevelUpButton");
            levelUpButton.onClick.AddListener(OnClickLevelUpButton);

        }

        private void OnClickLevelUpButton()
        {
            SendNotification(UserNotifications.LevelUp);
        }

        public override IList<string> ListNotificationInterests()
        {
            IList<string> list = new List<string>();
            list.Add(UserNotifications.LevelChange);
            return list;
        }

        public override void HandleNotification(INotification notification)
        {
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
