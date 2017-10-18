using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData
{
    private string id;
    private string pwd;
    private string name;
    private string age;

    public string Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public string Pwd
    {
        get
        {
            return pwd;
        }

        set
        {
            pwd = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public string Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }


    public UserData()
    {
        
    }

    public UserData(string _id, string _pwd, string _name, string _age)
    {
        this.id = _id;
        this.pwd = _pwd;
        this.name = _name;
        this.age = _age;
    }
}
