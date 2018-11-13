using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingStrategyInfomation.common;
using TradingStrategyInfomation;
using Common;

namespace TradingStrategyInfomation.MainForm
{
    public partial class ConnectToMcControl : UserControl
    {
        private BackgroundWorker m_loginWorker = null;

        private static MCData m_MCDataServer = null;

        public delegate void HandelRealMCData(RealMarketMCData threeKlineInfo);
        public event HandelRealMCData EventRealMCData;

        private bool m_canBroadCastData = false;

        public RedisHelper m_redisConn = null;


        public ConnectToMcControl()
        {
            InitializeComponent();

            this.textBox_PositionClass.Text = "RichEdit20W";
            this.textBox_title.Text = "000B09B2";

            this.EventRealMCData += ConnectToMcControl_EventRealMCData;

            try
            {
                m_redisConn = new RedisHelper();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("初始化redis异常:" + ex.Message);
            }
        }

        private void ConnectToMcControl_EventRealMCData(RealMarketMCData threeKlineInfo)
        {
            if (m_canBroadCastData)
            {
                this.m_redisConn.Publish<RealMarketMCData>(Entity.CHANNEL, threeKlineInfo);
            }
        }

        private void button_ConMc_Click(object sender, EventArgs e)
        {
            //WriteLine("请输入MC的公式编辑器的标题句柄，以及目标输出窗口的类名,用于给客户端传送MC公式编辑器输出窗口中的定时数据！", ConsoleColor.Red); //绿色  
            //WriteLine("MC公式编辑器的标题(spy++获取):", ConsoleColor.Green); //绿色  
            //string strMCEditTitle = Console.ReadLine();
            //WriteLine("目标输出窗口的类名(spy++获取):", ConsoleColor.Green); //绿色  
            //string strTargetEditOut = Console.ReadLine();

            try
            {
                m_MCDataServer = new MCData(this.textBox_title.Text, this.textBox_PositionClass.Text);
                m_MCDataServer.Start();

                m_loginWorker = new BackgroundWorker();
                m_loginWorker.DoWork += LoginWorker_DoWork;
                m_loginWorker.RunWorkerCompleted += LoginWorker_RunWorkerCompleted;
                m_loginWorker.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //线程获取行情，并广播出去；
        private void LoginWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (m_MCDataServer != null)
                {
                    string mcData = m_MCDataServer.GetNextMCEditOutInfo();
                    if (mcData != null && mcData != "")
                    {
                        //依次-->:
                        //前一根的：开，高，低，收，AVg,K,D 后一根的 ，当前的，三项
                        //   1180518.00 | 150000.00 | 110140.00 |  110140.00 | 11233 | 88 | 79
                        // | 1180518.00 | 150000.00 | 110140.00 |  110140.00 | 11233 | 88 | 79
                        // | 1180518.00 | 150000.00 | 110140.00 |  110140.00 | 11233 | 88 | 79
                        string[] arrayList = mcData.Split('|');
                        InsertTextInfo(mcData);

                        double[] threeAgo = new double[] { Convert.ToDouble(arrayList[0].Trim()), Convert.ToDouble(arrayList[1].Trim()), Convert.ToDouble(arrayList[2].Trim()), Convert.ToDouble(arrayList[3].Trim()), Convert.ToDouble(arrayList[4].Trim()), Convert.ToDouble(arrayList[5].Trim()), Convert.ToDouble(arrayList[6].Trim()) };
                        double[] twoAgo = new double[] { Convert.ToDouble(arrayList[7].Trim()), Convert.ToDouble(arrayList[8].Trim()), Convert.ToDouble(arrayList[9].Trim()), Convert.ToDouble(arrayList[10].Trim()), Convert.ToDouble(arrayList[11].Trim()), Convert.ToDouble(arrayList[12].Trim()), Convert.ToDouble(arrayList[13].Trim()) };
                        double[] oneAgo = new double[] { Convert.ToDouble(arrayList[14].Trim()), Convert.ToDouble(arrayList[15].Trim()), Convert.ToDouble(arrayList[16].Trim()), Convert.ToDouble(arrayList[17].Trim()), Convert.ToDouble(arrayList[18].Trim()), Convert.ToDouble(arrayList[19].Trim()), Convert.ToDouble(arrayList[20].Trim()) };

                        RealMarketMCData threeKlineInfo = new RealMarketMCData()
                        {
                            ThreeBarAgoInfo = threeAgo,
                            TwoBarAgoInfo = twoAgo,
                            NowBarInfo = oneAgo
                        };

                        if (EventRealMCData != null)
                        {
                            EventRealMCData(threeKlineInfo);
                        }
                    }
                }
            }
        }

        private void InsertTextInfo(string mcData)
        {
            //其他线程调用
            if (this.InvokeRequired)
            {
                IAsyncResult result = this.BeginInvoke(new Action<string>(InsertTextInfo), mcData);
                return;
            }
            this.textBox_NowMcItem.Text = mcData;
        }

        private void LoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void button_publish_Click(object sender, EventArgs e)
        {
            if (m_canBroadCastData == false)
            {
                m_canBroadCastData = true;
            }
            else
            {
                m_canBroadCastData = false;
            }
        }
    }
}
