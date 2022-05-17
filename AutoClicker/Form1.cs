using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AutoClicker
{
    public partial class MainProcess : Form
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        List<Point> positions = new List<Point>();
        private int posSize = 0;
        private const int LEFTUP = 0x0004;
        private const int LEFTDW = 0x0002;
        public int intervals = 1000;
        bool Click = false;
        Thread AC;
        Keys OnOff = Keys.Up;
        Keys SP = Keys.Right;
        private int index = 0;
        public MainProcess()
        {
            InitializeComponent();
            AC = new Thread(AutoClick);
        }
        private void btnCloseApp_Click(object sender, EventArgs e) { AC.Abort();  Application.Exit(); }
        private void btnMiniApp_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        bool mouseDown = false;
        private Point offset;
        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void pnlDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void pnlDrag_MouseUp(object sender, MouseEventArgs e) { mouseDown = false; }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            AC.Start();
            radioArrowUp.Checked = radioArrowRight.Checked = true;
        }
        private void MouseClick()
        {
            mouse_event(dwFlags: LEFTDW, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            Thread.Sleep(1);
            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
        }
        private void AutoClick()
        {
            while(true) 
            {
                if(Click)
                {
                    if(scp.Checked && posSize > 0)
                    {
                        SetCursorPos(positions[index].X, positions[index].Y);
                        index++;
                        if (index == posSize)
                            index = 0;
                    }
                    MouseClick();
                    Thread.Sleep(intervals);
                } 
                Thread.Sleep(2);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) 
            {
                if(onTop.Checked)
                    this.TopMost = true;
                else 
                    this.TopMost = false;
                Xpos.Text = $"X = {Cursor.Position.X}";
                Ypos.Text = $"Y = {Cursor.Position.Y}";
                if (enable.Checked)
                {
                    if (GetAsyncKeyState(OnOff) < 0)
                    {
                        if (Click == false)
                        {
                            Click = true;
                            btnToggle.Text = "Status: Working";
                        }
                        else
                        {
                            Click = false;
                            btnToggle.Text = "Status: Not Working";
                        }
                        Thread.Sleep(1000);
                    }
                }
                if (scp.Checked)
                {
                    if (GetAsyncKeyState(SP) < 0)
                    {
                        positions.Add(Cursor.Position);
                        posSize++;
                        posCount.Text = $"Positions: {posSize}";
                        Thread.Sleep(500);
                    }
                }
                Thread.Sleep(1);
            }
        }
        private void CPSTextBox_TextChanged(object sender, EventArgs e){}
        private void btnToggle_Click(object sender, EventArgs e){}
        private void btnCPS_Click(object sender, EventArgs e)
        {
            try
            {
                int parse = (Int32.Parse(CPSTextBox.Text) == 0) ? 1000 : Int32.Parse(CPSTextBox.Text);
                intervals = parse;
                CPSLabel.Text = $"Clicks per Second: {Math.Round(1000.0 / (double)parse, 3)}";
                CPSTextBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show($"Unable to parse '{CPSTextBox.Text}'");
            }
        }
        private void posCount_Click(object sender, EventArgs e){}
        private void btnResetPos_Click(object sender, EventArgs e)
        {
            index = posSize = 0;
            positions.Clear();
            posCount.Text = "Positions: 0";
        }
        private void btnSetControls_Click(object sender, EventArgs e)
        {
            if (radioArrowUp.Checked)
            {
                OnOff = Keys.Up;
                SetOnOffLabel.Text = "UP Arrow";
            }
            else if (radioF6key.Checked)
            {
                OnOff = Keys.F6;
                SetOnOffLabel.Text = "F6 key";
            }
            else if (radioNum8.Checked)
            {
                OnOff = Keys.NumPad8;
                SetOnOffLabel.Text = "Num8 Arrow";
            }
            if (radioArrowRight.Checked)
            {
                SP = Keys.Right;
                SetSetPosLabel.Text = "RIGHT Arrow";
            }
            else if (radioF7key.Checked)
            {
                SP = Keys.F7;
                SetSetPosLabel.Text = "F7 key";
            }
            else if (radioNum6.Checked)
            {
                SP = Keys.NumPad6;
                SetSetPosLabel.Text = "Num6 key";
            }
        }
    }
}
