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
using System.IO;

namespace WindowsFormsApp2
{
/// <summary>
/// Only for personal use. 
/// </summary>

  
         
    public partial class MTUCHECK : Form
    {

        public string Rname;
        public string logpath;
        public string mtucheckpath;
        public int index;
        public MTUCHECK()
        {
            InitializeComponent();
            Rname = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            logpath = Rname + "\\log.txt";
            mtucheckpath = Rname + "\\batch.bat";
            if (File.Exists(logpath))
            {//로그파일이 존재한다면 수행
                string text = File.ReadAllText(logpath);
                T_mtuenter.Text = text;
                T_mtuenter.ReadOnly = true;
                checkBox1.Checked = true;
            }

        }
        private string func(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);/* command here */
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit(1);
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            string txt = cmd.StandardOutput.ReadLine(); 
            return txt;
        }
        private void B_mtu400_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(T_mtuenter.Text);
            string ans=func($"netsh interface ipv4 set subinterface \"{index}\" mtu=400 store=active ");
            if (ans==null) AutoClosingMessageBox.Show($"mtu=400", "알림", 1000);
        }

        private void B_mtu1500_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(T_mtuenter.Text);
            string ans=func($"netsh interface ipv4 set subinterface \"{index}\" mtu=1500 store=persistent");
            if (ans == null) AutoClosingMessageBox.Show($"mtu=1500", "알림", 1000);
        }

        private void B_mtuetc_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt32(T_mtuenter.Text);
            int x=0;
            bool temp = Int32.TryParse(T_usermtu.Text, out x);
            if (T_usermtu.Text == "" || x<400 ||temp==false) AutoClosingMessageBox.Show("유효하지 않은 값입니다. MTU는 400~1500사이의 숫자값으로만 입력할 수 있습니다", "알림", 1000);
            else
            {
                string ans = func($"netsh interface ipv4 set subinterface \"{index}\" mtu={x.ToString()} store=persistent");
                if (ans == null) AutoClosingMessageBox.Show($"mtu={x.ToString()}", "알림", 1000);

            }
            
        }

        private void B_mtuCHECK_Click(object sender, EventArgs e)
        {
            //unlock
            string ans = func("netsh interface ip set global minmtu=352");
            //if (ans == null) AutoClosingMessageBox.Show("minmtu=352","알림", 1000);
            //check net index

            Process.Start(mtucheckpath);
        }

        private void mtuhold(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                T_mtuenter.ReadOnly = false;
                T_mtuenter.Text = "";
            }
            else
            {
                T_mtuenter.ReadOnly = true;
                //있던없던 정해진 상대경로에 수행
                int x = 0;
                bool temp = Int32.TryParse(T_mtuenter.Text, out x);
                if (T_mtuenter.Text == "" || temp == false || x <= 0)
                {
                    MessageBox.Show("정확한 mtu값을 입력하세요");
                    checkBox1.Checked = false;
                }
                else if (temp == true && x > 0)
                {
                    File.Delete(logpath); //일단 패스 지움
                    using (StreamWriter sw = File.CreateText(logpath))
                    {
                        sw.WriteLine(T_mtuenter.Text);
                    }
                }
            }
        }
    }
}
