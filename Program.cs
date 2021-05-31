using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ExceptionServices;
using System.IO;
using System.Configuration;
using System.Windows;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32.SafeHandles;

namespace Win10Maid
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        //June 13th, 2020 Update:
        //静态函数：提示音，Console.Beep()实现。
        static void NotiSound()
        {
            Console.Beep(400, 400);
            Console.Beep(600, 300);
        }

        //June 13th, 2020 Update:
        //静态函数：读取环境变量，并弹窗提示打开日志文件/日志文件的路径。
        static void PEndNoErrorPrompt()
        {
            //获取名为"userprofile"的环境变量，导出为字符串（env），无需输入%。
            string env = Environment.GetEnvironmentVariable("USERPROFILE");
            if (MessageBox.Show("The program ended without errors. \nClick Yes to view AdminCon.log\n" +
                "Click No to quit.",
                "PROCESS_END", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                Process.Start(env);
            }
            else
            {
                MessageBox.Show("Path of your log file: " + env + @"\AdminCon.log", "Dialog - LogFilePath",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    Application.Run(new winmaidForm());
                }catch (Exception ex)
                {
                    //不对异常进行任何处理（忽略）。
                    string exMessage = ex.Message;//NO WARNINGS
                }
                PEndNoErrorPrompt();//调用：第30行。
                NotiSound();
            }
            catch (Exception ex)
            {
                //不对异常进行任何处理（忽略）。
                string exceptionMessage = ex.Message;//NO WARNINGS
            }
        }
    }
}
