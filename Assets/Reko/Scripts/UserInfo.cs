using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Reko.Scripts
{
    public class UserInfo
    {
        private int level;

        /// <summary>
        /// 等级
        /// </summary>
        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        private int hp;
        /// <summary>
        /// 生命值
        /// </summary>
        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public UserInfo() { }

        public UserInfo(int _level,int _hp)
        {
            level = _level;
            hp = _hp;
        }

    }
}
