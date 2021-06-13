using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace COM3D2.StopQuitting.Plugin
{
    class MyAttribute
    {
        public const string PLAGIN_NAME = "StopQuitting";
        public const string PLAGIN_VERSION = "21.6.13";
        public const string PLAGIN_FULL_NAME = "COM3D2.StopQuitting.Plugin";
    }

    [BepInPlugin(MyAttribute.PLAGIN_FULL_NAME, MyAttribute.PLAGIN_FULL_NAME, MyAttribute.PLAGIN_VERSION)]// 버전 규칙 잇음. 반드시 2~4개의 숫자구성으로 해야함. 미준수시 못읽어들임
    //[BepInPlugin("COM3D2.Sample.Plugin", "COM3D2.Sample.Plugin", "21.6.6")]// 버전 규칙 잇음. 반드시 2~4개의 숫자구성으로 해야함. 미준수시 못읽어들임
    [BepInProcess("COM3D2x64.exe")]
    public class StopQuitting
    {
        public void Awake()
        {
            try
            {
                GameMain.Instance.CMSystem.QuitWhenAssert = false;
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.ToString());
            }
        }
    }
}
