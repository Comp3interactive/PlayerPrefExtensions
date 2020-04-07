using System.Collections.Generic;
using UnityEngine;

public static class Comp3PlayerPrefs
{
    public static void SetBool(string key, bool val)
    {
        PlayerPrefs.SetInt(key, val == false ? 0 : 1);
    }
    public static bool GetBool(string key)
    {
        return PlayerPrefs.GetInt(key) == 0 ? false : true;
    }
    public static void SetVector3(string key, Vector3 v3)
    {
        PlayerPrefs.SetString(key, DelimitFloats(new float[] { v3.x,v3.y,v3.z}));
    }
    public static Vector3 GetVector3(string key)
    {
        Vector3 v3 = new Vector3(0, 0, 0);

        if (PlayerPrefs.HasKey(key))
        {
            float[] f = ParseDelimitedFloats(PlayerPrefs.GetString(key));

            v3.x = f[0];
            v3.y = f[1];
            v3.z = f[2];
        }

        return v3;
    }
    public static void SetVector2(string key, Vector2 v2)
    {
        PlayerPrefs.SetString(key, DelimitFloats(new float[] { v2.x, v2.y }));
    }
    public static Vector2 GetVector2(string key)
    {
        Vector2 v2 = new Vector3(0, 0, 0);

        if (PlayerPrefs.HasKey(key))
        {
            float[] f = ParseDelimitedFloats(PlayerPrefs.GetString(key));

            v2.x = f[0];
            v2.y = f[1];
        }

        return v2;
    }
    public static void SetQuaternion(string key, Quaternion q)
    {
        PlayerPrefs.SetString(key, DelimitFloats(new float[] { q.x, q.y, q.z, q.w}));
    }
    public static Quaternion GetQuaternion(string key)
    {
        Quaternion q = new Quaternion(0, 0, 0, 0);

        if (PlayerPrefs.HasKey(key))
        {
            float[] f = ParseDelimitedFloats(PlayerPrefs.GetString(key));

            q.x = f[0];
            q.y = f[1];
            q.z = f[2];
            q.w = f[3];
        }

        return q;
    }

    #region Interal Utility Methods
    private static string DelimitFloats(float[] floats)
    {
        string s = "";

        foreach(float f in floats)
            s += f.ToString() + "-";

        return s.Substring(0, s.Length - 1);
    }

    private static float[] ParseDelimitedFloats(string key)
    {
        var floatList = new List<float>();
        
        foreach(string s in key.Split('-'))
            floatList.Add(float.Parse(s));

        return floatList.ToArray();
    }
    #endregion
}
