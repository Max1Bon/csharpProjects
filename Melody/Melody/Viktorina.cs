﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Melody
{
    static class Viktorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomeStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;

        static public void ReadMusic()
        {
            try
            {
                string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music_files);
            }
            catch {}
        }

        static string regKeyName = "Software\\MyCompanyName\\Victorina";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomeStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null; 
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk!= null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    randomeStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories", false));
                }
            } finally
            {
                if (rk != null) rk.Close();  
            }
        }
    }
}
