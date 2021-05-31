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

/// <summary>
/// 窗体控件的业务逻辑。
/// </summary>
namespace Win10Maid
{
    public partial class winmaidForm : Form
    {
        public winmaidForm()
        {
            InitializeComponent();
        }
        //以下代码可实现将基于命令行的运算结果打印到RichTextBox。
        public Process Process = null;//初始化进程为空。
        private string OutPutForm_Shown(string CMDcommand)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Process = new Process();
            Process.StartInfo.FileName = "cmd.exe";
            Process.StartInfo.WorkingDirectory = ".";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            //Process.Start("cmd.exe");
            Process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            Process.Start();


            Process.StandardInput.WriteLine(CMDcommand);//Execute commands

            //Process.StandardInput.WriteLine("exit");


            Process.BeginOutputReadLine();
            //using (StreamWriter sw = new StreamWriter("output.log"))
            //{
            // sw.WriteLine(Process.StandardOutput.ReadToEnd());
            //}

            return CMDcommand;
        }
        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                try
                {
                    StringBuilder sb = new StringBuilder(
                        this.OutputRichTextBox.Text);
                    try
                    {
                        this.OutputRichTextBox.Text = sb.AppendLine(outLine.Data).ToString();
                    }catch (Exception ex)
                    {
                        string exeptionMessage = ex.Message; //NO WARNINGS
                    }
                    this.OutputRichTextBox.SelectionStart = this.OutputRichTextBox.Text.Length; //Update data by frame and output strings
                    this.OutputRichTextBox.ScrollToCaret();
                }catch(Exception ex)
                {
                    /*
                     * 当前output未执行完成时，如果强行执行另一项output，将会导致
                     * 内存访问冲突，故此处放置一个抓取Exception的功能。
                     * 不对异常进行任何处理（忽略）。
                     */
                    string exMessage = ex.Message;//NO WARNINGS
                }
            }
        }
        public void executeCmd(string Command)
        {
            Process p = new Process();
            p.StartInfo.FileName = " cmd.exe ";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(Command);
            p.StandardInput.WriteLine("exit");
            p.WaitForExit();
            this.OutputRichTextBox.Text = OutputRichTextBox.Text + p.StandardOutput.ReadToEnd();
            // this.OutputRichTextBox.SelectionStart = this.OutputRichTextBox.Text.Length;
            p.Close();
        }
        private void OutPutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Process != null)
                Process.Close();
        }
        //以上代码可实现将基于命令行的运算结果打印到RichTextBox。

        //公共函数：获取Process ID：
        public int getProcessID(string processName)
        {
            string PName = processName;
            int pid = -1;
            Process[] processArray = Process.GetProcessesByName(PName);
            //集合Process[]的第一个元素，就是目标进程。Id方法可以获取此进程的PID。
            pid = processArray[0].Id;
            //函数的最终返回值为PID，以便调用时提供PID的访问接口。
            return pid;
        }
        //公共函数：提示音，利用Console.Beep()实现。
        public void NotiSound()
        {
            Console.Beep(400, 500);;
        }

        //公共函数：按照顺序逐个杀死进程。
        public void KillProcesses()
        {
            /*
             * 通过 Process.GetProcessByName(ProcessName)方法，
             * 将目标进程打印至集合，
             * 再将集合中的目标进程杀死。
             */
            Process[] proArray_taskmgr = Process.GetProcessesByName("taskmgr");
            foreach (Process pro in proArray_taskmgr)
            {
                pro.Kill();
            }
            Process[] proArray_cleanmgr = Process.GetProcessesByName("cleanmgr");
            foreach (Process pro in proArray_cleanmgr)
            {
                pro.Kill();
            }
            Process[] proArray_ping = Process.GetProcessesByName("ping");
            foreach (Process pro in proArray_ping)
            {
                pro.Kill();
            }
            Process[] proArray_regedit = Process.GetProcessesByName("regedit");
            foreach (Process pro in proArray_regedit)
            {
                pro.Kill();
            }
        }
        //June 13th, 2020 Update:
        /* 
         * 公共函数：利用cmd写入记录操作的日志文件（echo string >> %path%）。
         * 函数LogFileCreate(string)输入参数后，按照指定格式写入log文件。
         */
        public void LogFileCreate(string ProcessName)
        {
            string DateAndTime = Convert.ToString(System.DateTime.Now);
            string InputString = "AdminCon- " + DateAndTime + ": " + ProcessName;
            OutPutForm_Shown("echo " + InputString + ">>" + "%userprofile%\\AdminCon.log");
        }
        //June 13th, 2020 Update:
        //公共函数：检查进度条的值范围。
        public bool ProgressBarValueValidator()
        {
            if (progressBar.Value == 0) return true;
            else return false;
        }
        //公共函数：控制进度条。调用公共函数ProgressBarValueValidator以进行判断。
        public void ProgressBarController()       {
            progressBar.Value = 0; //初始化进度条的值。
            if (ProgressBarValueValidator() == true)
            {
                progressBar.Value = progressBar.Value + 100;
            }
        }
        //以下公共函数为控件的功能实现和业务逻辑。
        //所有异常（Exception）均由MessageBox显示。
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void winmaidForm_Load(object sender, EventArgs e)
        {

        }

        private void cleanmgrButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cleanmgr.exe");
                LogFileCreate("Disk Cleanup");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //在日志文件中写入Exception的信息。下同。
                LogFileCreate("Exception Found: " + ex.Message);//调用：第146行。
            }
        }

        private void diskmgmtButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("diskmgmt.msc");
                LogFileCreate("Disk Management");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            //CMD执行“ping + 指定IP地址”命令后，将结果打印至RichTextBox。
            //指定ip地址由ipInputBox提供。
            try
            {
                OutputRichTextBox.Text = OutPutForm_Shown("ping "+ipInputBox.Text);//调用：第30行。
                LogFileCreate("ping " + ipInputBox.Text);
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void ipInputBox_TextChanged(object sender, EventArgs e)
        {
            //为控件“pingButton”提供参数。
        }

        private void devmgmtButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("devmgmt.msc");
                LogFileCreate("Device Manager");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("services.msc");
                LogFileCreate("Services");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void taskmgrButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("taskmgr.exe");
                LogFileCreate("Task Manager");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void tempButton_Click(object sender, EventArgs e)
        {
            try
            {
                string env = Environment.GetEnvironmentVariable("temp");//获取名为“temp”的环境变量。
                Process.Start(env);
                LogFileCreate("Opened Temporary File Folder");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void regeditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
                LogFileCreate("Registry Editor");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }

        private void endAllProcessButton_Click(object sender, EventArgs e)
        {
            KillProcesses();//调用：第113行。
            LogFileCreate("Killed current exe Applications");
            ProgressBarController();//调用：第166行。
            NotiSound();//调用：第118行
        }

        private void runAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                //依照名称逐个运行。
                Process.Start("DISKMGMT.MSC");
                Process.Start("taskmgr.exe");
                Process.Start("cleanmgr.exe");
                Process.Start("devmgmt.msc");
                NotiSound();//调用：第118行
                Process.Start("services.msc");
                Process.Start("regedit.exe");
                LogFileCreate("Ran all applications");
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
        }
        private void powershellButton_Click(object sender, EventArgs e)
        {
            Process.Start("powershell.exe");
            LogFileCreate("Powershell");
            ProgressBarController();//调用：第166行。
        }

        private void taskkillButton_Click(object sender, EventArgs e)
        {
            /* 
             * 选中checkbox后，此按钮的显示文本会变化，
             * 而控件的功能也随显示文本的不同而改变。
             */
            if(taskkillButton.Text == "Get PID By Name")
            {
                //按钮显示指定文本时，执行寻找PID的功能。
                try
                {
                    ProgressBarController();//调用：第166行。
                    MessageBox.Show("PID: "+Convert.ToString(getProcessID(PNameTextBox.Text)),
                        "Process ID:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogFileCreate("Process: " + PNameTextBox.Text + "; " + "PID - " +
                        Convert.ToString(getProcessID(PNameTextBox.Text)));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Process Not Found" + "\n" + ex.Message, "ERROR - EXCEPTION FOUND",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogFileCreate("Exception Found: " + ex.Message);
                }
                PNameTextBox.Clear();
            }
            else if(taskkillButton.Text == "Kill Process By Name")//按钮显示指定文本时，执行杀死指定名称进程的功能。
            {
                ProgressBarController();//调用：第166行。
                //June 13th, 2020 Update:
                //svchost属于重要的系统进程，强行杀死会导致蓝屏重启，故需要进行确认。
                if(PNameTextBox.Text == "svchost" || PNameTextBox.Text == "svchost.exe")
                {
                    if(MessageBox.Show("svchost.exe is an important system process. \nAre you sure?",
                        "CRITICAL_PROCESS_DIED CAUTION",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Process[] svchost_Array = Process.GetProcessesByName("svchost");
                        foreach(Process p in svchost_Array)
                        {
                            p.Kill();
                        }
                    }
                    else { MessageBox.Show("Access Cancelled.", "CANCELLED_BY_ADMIN", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LogFileCreate("Process Kill: " + PNameTextBox.Text + " - " + "Cancelled");
                        PNameTextBox.Clear(); }
                }
                //June 13th, 2020 Update:
                //services：如果用户想要杀死services进程，直接禁止请求。
                //直接禁止请求的原因：尝试杀死services，程序会直接退出，所以最好在输入框就做出限制。
                else if (PNameTextBox.Text == "services")
                {
                    MessageBox.Show("Access Denied.", "ACCESS_DENIED_BY_SYSTEM", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    Process[] ProcessArray = Process.GetProcessesByName(
                        PNameTextBox.Text);
                    foreach (Process p in ProcessArray)
                    {
                        p.Kill();
                    }
                    MessageBox.Show("Process Killing Complete, or Process Not Found", "NO EXCEPTION FOUND",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogFileCreate("Process: " + PNameTextBox.Text + " - " + "Killed or Not Found");
                    PNameTextBox.Clear();
                }
            }
        }

        private void getPIDorTASKKILLcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //控件功能：选中checkbox后，可以更改taskkillButton的文本，进而改变其功能。
            if(getPIDorTASKKILLcheckBox.Checked)
            {
                taskkillButton.Text = "Get PID By Name";
            }
            else
            {
                taskkillButton.Text = "Kill Process By Name";
            }
        }

        private void PNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PIDlistButton_Click(object sender, EventArgs e)
        {
            //CMD执行“tasklist”命令后，将结果打印至RichTextBox。
            try
            {
                OutputRichTextBox.Text = OutPutForm_Shown("tasklist");//调用：第30行。
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
            finally
            {
                LogFileCreate("Listed All processes and PIDs");
            }
        }
        private void ipConfigButton_Click(object sender, EventArgs e)
        {
            //CMD执行“ipconfig”命令后，将结果打印至RichTextBox。
            try
            {
               OutputRichTextBox.Text = OutPutForm_Shown("ipconfig /all");//调用：第30行。
                ProgressBarController();//调用：第166行。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR - EXCEPTION FOUND", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LogFileCreate("Exception Found: " + ex.Message);
            }
            finally
            {
                LogFileCreate("IP Configuration");
            }
        }

        //June 13th, 2020 Update:
        //引入了进度条。
        private void progressBar_Click(object sender, EventArgs e)
        {
            //控制进度条输出的公共函数已经定义完，此处无需配置任何代码。
            //定义进度条的函数位置：第156到169行。
        }

        private void OutputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            //用于打印基于命令行显示的运行结果（ping，ipconfig。tasklist）
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
