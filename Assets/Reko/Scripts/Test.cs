using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Reko.Scripts
{
    public class Test:MonoBehaviour
    {
        void Start()
        {
            new TestFacade(gameObject);
        }
    }
}
