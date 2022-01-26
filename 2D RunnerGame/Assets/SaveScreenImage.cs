using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScreenImage : MonoBehaviour
{
    public string m_Path = @"C:\Users\wkzkx\Desktop\";
    public string m_FilePrefix = "CoderZero";
    private string m_FilePath;

    private void Update()
    {
        SaveButtonJpg();
    }

    public void SaveButtonJpg()
    {
        m_FilePath = m_Path + m_FilePrefix + DateTime.Now.ToString("yyyyMMddhhmmss") + ".jpg";
        StartCoroutine(SaveScreenJpg(m_FilePath));
    }

    IEnumerator SaveScreenJpg(string filePath)
    {
        yield return new WaitForEndOfFrame();

        Texture2D texture = new Texture2D(Screen.width, Screen.height);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();
        byte[] bytes = texture.EncodeToJPG();
        File.WriteAllBytes(filePath, bytes);
        DestroyImmediate(texture);
    }
    
}
