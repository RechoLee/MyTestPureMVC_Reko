using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginVO
{
    private string id;
    private string pwd;

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
}