using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用于获取Transform或者Component的类
/// </summary>
public class GameUtilis : MonoBehaviour
{
    /// <summary>
    /// 获取子物体
    /// </summary>
    /// <param name="root">根节点对象</param>
    /// <param name="path">名称</param>
    /// <returns></returns>
    public static Transform GetTransform(GameObject root, string path)
    {
        Transform tra = root.transform.Find(path);
        if (tra == null)
            Debug.Log(path + "is not find");
        return tra;
    }

    /// <summary>
    /// 获取组件
    /// </summary>
    /// <typeparam name="T">组件类型</typeparam>
    /// <param name="root">根节点</param>
    /// <param name="path">unity中的树状路径</param>
    /// <returns></returns>
    public static T GetComponent<T>(GameObject root ,string path) where T:Component
    {
        Transform tra = root.transform.Find(path);
        if (null == tra)
            Debug.Log(path + "component is not find");
        T t = tra.GetComponent<T>();
        return t;
    }
}