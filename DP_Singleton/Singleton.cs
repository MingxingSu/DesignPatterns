using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Singleton
{
    /// <summary>
    /// Author:Mingxing Su
    /// Time:2016-30-25
    /// </summary>
    public class Singleton
    {
        static Singleton()
        {
            LoadSettings();
        }

        private Singleton()
        {
        }

        private static Singleton _instance = null;

        public static Singleton GetInstance()
        {
            Object syncFlag = new object();

            if (_instance == null)
            {
                lock (syncFlag)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        private static void LoadSettings()
        {
           Console.WriteLine("All application setting have been loaded!");
        }
    }
}
