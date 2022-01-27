using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScreenImage : MonoBehaviour
{
    public string m_Path = @"C:\Users\wkzkx\";
    public string m_FilePrefix = "CoderZero";
    private string m_FilePath;


    public Image testimg;

    private void Update()
    {
        
    }

    public void SaveButtonJpg()
    {
        m_FilePath = m_Path + m_FilePrefix + DateTime.Now.ToString("yyyyMMddhhmmss") + ".jpg";
        StartCoroutine(SaveScreenJpg(m_FilePath));
        Debug.Log("Click");
    }

    IEnumerator SaveScreenJpg(string filePath)
    {
        yield return new WaitForEndOfFrame();

        Texture2D texture = new Texture2D(100, 100);
        texture.ReadPixels(new Rect(testimg.transform.position.x, testimg.transform.position.y, Screen.width, Screen.height), 0, 0);
        texture.Apply();
        byte[] bytes = texture.EncodeToJPG();
        File.WriteAllBytes(filePath, bytes);
        DestroyImmediate(texture);
    }
    
}
