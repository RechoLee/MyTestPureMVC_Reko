using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Reko.Scripts
{
    /// <summary>
    ///用户数据，相当于mvc中的元数据
    /// </summary>
    public class UserInfo
    {
        private int level;

        /// <summary>
        /// 等级属性
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
        /// 生命值属性
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

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="_level"></param>
        /// <param name="_hp"></param>
        public UserInfo(int _level,int _hp)
        {
            level = _level;
            hp = _hp;
        }

    }
}
