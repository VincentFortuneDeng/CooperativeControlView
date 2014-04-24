using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CooperativeControlView
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load user layout file if it exists
            if (Environment.UserName != "")
            {
                if (System.IO.File.Exists(Environment.UserName + ".xml"))
                {
                    navigationPane1.LoadLayout(Environment.UserName + ".xml");
                }
            }

            navigationPane1.Expanded = false;
            comboBoxEx1.SelectedIndex = 1;
            comboBoxEx2.SelectedIndex = 0;
            dateTimeInput1.Value = DateTime.Now;
            integerInput2.Value = DateTime.Now.Minute;
            integerInput1.Value = DateTime.Now.Hour;

            treeView1.ExpandAll();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save Navigation Pane Layout 
            if (Environment.UserName != "")
            {
                try
                {
                    navigationPane1.SaveLayout(Environment.UserName + ".xml");
                }
                catch (UnauthorizedAccessException)
                {
                    // Ignore the access exceptions...
                }
            }
        }

        private void treeView5_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
            textBoxX2.Text = e.Node.Text;
        }

        private void navigationPane1_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (e.NewExpandedValue)
            {
                groupPanel1.Visible = false;
                groupPanel2.Visible = true;
                groupPanel1.Dock = DockStyle.None;
                groupPanel2.Dock = DockStyle.Fill;
            }

            else
            {
                groupPanel1.Visible = true;
                groupPanel2.Visible = false;
                groupPanel1.Dock = DockStyle.Fill;
                groupPanel2.Dock = DockStyle.None;
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            groupPanel2.Text = "发件箱";
            listViewEx4.Visible = false;
            listViewEx3.Visible = true;
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            groupPanel2.Text = "收件箱";
            listViewEx4.Visible = false;
            listViewEx3.Visible = true;
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            groupPanel2.Text = "已发送";
            listViewEx4.Visible = false;
            listViewEx3.Visible = true;
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            groupPanel2.Text = "联系人";
            listViewEx4.Visible = true;
            listViewEx3.Visible = false;
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx2.SelectedIndex == 0)
            {
                listViewEx1.Columns[0].Text = "联系人";
                listViewEx1.Columns[1].Text = "电话";
                listViewEx1.Items[0].Text = "机场A";
                listViewEx1.Items[0].SubItems[0].Text = "机场A";
                listViewEx1.Items[0].SubItems[1].Text = "电话13890809900";

                listViewEx1.Items[1].Text = "机场B";
                listViewEx1.Items[1].SubItems[0].Text = "机场B";
                listViewEx1.Items[1].SubItems[1].Text = "电话15037773737";

                listViewEx3.Columns[0].Text = "联系人";
                listViewEx3.Columns[1].Text = "微信";
                listViewEx3.Items[0].Text = "机场A";
                listViewEx3.Items[0].SubItems[0].Text = "机场A";
                listViewEx3.Items[0].SubItems[1].Text = "微信13890809900";

                listViewEx3.Items[1].Text = "机场B";
                listViewEx3.Items[1].SubItems[0].Text = "机场B";
                listViewEx3.Items[1].SubItems[1].Text = "微信15037773737";

                //listViewEx1.Items[1].SubItems[0].Text = "13890809900";
                //    System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
                //"机场A",
                //"13890809900",
                //"微信"}, -1);
                //    System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
                //"机场B",
                //"15037773737"}, -1);
                //    System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                //"机场A",
                //"13890809900",
                //"微信"}, -1);
                //    System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
                //"机场B",
                //"15037773737"}, -1);
            }

            else if (comboBoxEx2.SelectedIndex == 1)
            {
                listViewEx1.Columns[0].Text = "联系人";
                listViewEx1.Columns[1].Text = "电话";
                listViewEx1.Items[0].Text = "空管A";
                listViewEx1.Items[0].SubItems[0].Text = "空管A";
                listViewEx1.Items[0].SubItems[1].Text = "电话13890809900";

                listViewEx1.Items[1].Text = "空管B";
                listViewEx1.Items[1].SubItems[0].Text = "空管B";
                listViewEx1.Items[1].SubItems[1].Text = "电话15037773737";

                listViewEx3.Columns[0].Text = "联系人";
                listViewEx3.Columns[1].Text = "微信";
                listViewEx3.Items[0].Text = "空管A";
                listViewEx3.Items[0].SubItems[0].Text = "空管A";
                listViewEx3.Items[0].SubItems[1].Text = "微信13890809900";

                listViewEx3.Items[1].Text = "空管B";
                listViewEx3.Items[1].SubItems[0].Text = "空管B";
                listViewEx3.Items[1].SubItems[1].Text = "微信15037773737";

            }

            else if (comboBoxEx2.SelectedIndex == 2)
            {
                listViewEx1.Columns[0].Text = "联系人";
                listViewEx1.Columns[1].Text = "电话";
                listViewEx1.Items[0].Text = "监管A";
                listViewEx1.Items[0].SubItems[0].Text = "监管A";
                listViewEx1.Items[0].SubItems[1].Text = "电话13890809900";

                listViewEx1.Items[1].Text = "监管B";
                listViewEx1.Items[1].SubItems[0].Text = "监管B";
                listViewEx1.Items[1].SubItems[1].Text = "电话15037773737";

                listViewEx3.Columns[0].Text = "联系人";
                listViewEx3.Columns[1].Text = "微信";
                listViewEx3.Items[0].Text = "监管A";
                listViewEx3.Items[0].SubItems[0].Text = "监管A";
                listViewEx3.Items[0].SubItems[1].Text = "微信13890809900";

                listViewEx3.Items[1].Text = "监管B";
                listViewEx3.Items[1].SubItems[0].Text = "监管B";
                listViewEx3.Items[1].SubItems[1].Text = "微信15037773737";

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (checkBoxX1.Checked)
            {
                switch (comboBoxEx2.SelectedIndex)
                {
                    case 0:
                        textEvents.AppendText(DateTime.Now.ToString() + "向 【机场组】发送的消息将在" + dateTimeInput1.Value.ToString("yyyy-MM-dd ") + integerInput1.Value + ":" + integerInput2.Value + "定时发送." + "\r\n");
                        break;

                    case 1:
                        textEvents.AppendText(DateTime.Now.ToString() + "向 【空管组】发送的消息将在" + dateTimeInput1.Value.ToString("yyyy-MM-dd ") + integerInput1.Value + ":" + integerInput2.Value + "定时发送." + "\r\n");
                        break;

                    case 2:
                        textEvents.AppendText(DateTime.Now.ToString() + "向 【监管组】发送的消息将在" + dateTimeInput1.Value.ToString("yyyy-MM-dd ") + integerInput1.Value + ":" + integerInput2.Value + "定时发送." + "\r\n");
                        break;
                }
            }

            else
            {
                switch (comboBoxEx2.SelectedIndex)
                {
                    case 0:
                        textEvents.AppendText(DateTime.Now.ToString() + "向 【机场组】发送的消息完成." + "\r\n");
                        break;

                    case 1:
                        textEvents.AppendText(DateTime.Now.ToString() + "向 【空管组】发送的消息完成." + "\r\n");
                        break;

                    case 2:
                        textEvents.AppendText(DateTime.Now.ToString() + "向 【监管组】发送的消息完成." + "\r\n");
                        break;
                }
            }
        }

        private void listViewEx2_DoubleClick(object sender, EventArgs e)
        {
            Form2 message = new Form2();
            message.TopMost = true;
            message.ShowDialog();
        }
    }
}
