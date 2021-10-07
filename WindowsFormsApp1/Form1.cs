using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI1.CommConnect() == 0)
                listBox1.Items.Add("로그인 시작");
            else
                listBox1.Items.Add("로그인 실패");
            axKHOpenAPI1.OnEventConnect += onEventConnect;
        }

        public void onEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                listBox1.Items.Add("로그인 성공");
                if (axKHOpenAPI1.GetConnectState() == 1)
                    listBox1.Items.Add("접속상태:연결중");
                else if (axKHOpenAPI1.GetConnectState() == 0)
                    listBox1.Items.Add("접속상태:미연결");
            }
        }
    }
}
