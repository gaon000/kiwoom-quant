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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.SetInputValue("종목코드", stockcode_textbox.Text.Trim());
            int nRet = axKHOpenAPI1.CommRqData("주식기본정보", "OPT10001", 0, "1001");
            if (nRet == 0)
                listBox1.Items.Add("주식 정보요청");
            else
                listBox1.Items.Add("주식 정보요청 실패");
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData조회;
        }

        public void onReceiveTrData조회(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "주식기본정보")
            {
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                for (int nIdx = 0; nIdx <= nCnt; nIdx++)
                {
                    listBox1.Items.Add("종목코드" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "종목코드").Trim());
                    listBox1.Items.Add("종목명" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "종목명").Trim());
                    stockname_label.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "종목명").Trim();
                }
            }
        }
    }
}
