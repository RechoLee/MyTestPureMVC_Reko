using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEngine;

//用于模拟数据库用户表
public static class  UserTable
{
    private static List<UserData> list;

    static UserTable()
    {
        list=new List<UserData>();
        Init();
    }

    public static void  Init()
    {
        UserData use1=new UserData("101","123","张三","20");
        UserData use2 = new UserData("102", "456", "李四", "20");
        UserData use3 = new UserData("103", "789", "Reko", "20");
        list.Add(use1);
        list.Add(use2);
        list.Add(use3);
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
