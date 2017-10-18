using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEngine;

//用于模拟数据库用户表
public class UserTable
{
    private static List<UserData> list;

    public UserTable()
    {
        list=new List<UserData>();
        Init();
    }

    public static void  Init()
    {
        UserData use1=new UserData("101","123","张三","20");
        UserData use2 = new UserData("102", "456", "李四", "20");
        UserData use3 = new UserData("103", "789", "Reko", "20");
    }

    public static void AddUser(UserData user)
    {
        list.Add(user);
    }

    public static bool IsExit(string id, string pwd)
    {
        foreach (var item in list)
        {
            if (string.Equals(item.Id, id) && string.Equals(item.Pwd, pwd))
            {
                return true;
            }
        }
        return false;
    }
}
