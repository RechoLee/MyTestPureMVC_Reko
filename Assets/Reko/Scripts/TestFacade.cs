using PureMVC.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Reko.Scripts
{
    public class TestFacade:Facade
    {
        public TestFacade(GameObject canvas)
        {
            RegisterCommand(UserNotifications.LevelUp, typeof(TestCommand));
            RegisterMediator(new TestMediator(canvas));
            RegisterProxy(new TestProxy());

        }
    }
}
