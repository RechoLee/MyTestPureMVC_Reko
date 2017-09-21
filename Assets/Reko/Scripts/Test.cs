using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Reko.Scripts
{
    /// <summary>
    /// 测试类 调用Facade
    /// </summary>
    public class Test:MonoBehaviour
    {
        void Start()
        {
            new TestFacade(gameObject);
        }
    }
}
