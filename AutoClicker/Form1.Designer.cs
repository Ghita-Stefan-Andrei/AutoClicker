namespace AutoClicker
{
    partial class MainProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMiniApp = new System.Windows.Forms.Button();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CPSLabel = new System.Windows.Forms.Label();
            this.posCount = new System.Windows.Forms.Label();
            this.cursorPos = new System.Windows.Forms.Label();
            this.Xpos = new System.Windows.Forms.Label();
            this.Ypos = new System.Windows.Forms.Label();
            this.CPSTextBox = new System.Windows.Forms.TextBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.enable = new System.Windows.Forms.CheckBox();
            this.scp = new System.Windows.Forms.CheckBox();
            this.btnCPS = new System.Windows.Forms.Button();
            this.btnResetPos = new System.Windows.Forms.Button();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioNum6 = new System.Windows.Forms.RadioButton();
            this.radioF7key = new System.Windows.Forms.RadioButton();
            this.radioArrowRight = new System.Windows.Forms.RadioButton();
            this.SetSetPosLabel = new System.Windows.Forms.Button();
            this.setPosLabel = new System.Windows.Forms.Label();
            this.SetPosSetLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioNum8 = new System.Windows.Forms.RadioButton();
            this.radioF6key = new System.Windows.Forms.RadioButton();
            this.radioArrowUp = new System.Windows.Forms.RadioButton();
            this.SetOnOffLabel = new System.Windows.Forms.Button();
            this.onOffLabel = new System.Windows.Forms.Label();
            this.OnOffSetLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.btnSetControls = new System.Windows.Forms.Button();
            this.onTop = new System.Windows.Forms.CheckBox();
            this.nrClicksLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.pnlDrag.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Location = new System.Drawing.Point(322, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(20, 20);
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnMiniApp
            // 
            this.btnMiniApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.btnMiniApp.FlatAppearance.BorderSize = 0;
            this.btnMiniApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniApp.Location = new System.Drawing.Point(296, 12);
            this.btnMiniApp.Name = "btnMiniApp";
            this.btnMiniApp.Size = new System.Drawing.Size(20, 20);
            this.btnMiniApp.TabIndex = 0;
            this.btnMiniApp.Text = "-";
            this.btnMiniApp.UseVisualStyleBackColor = false;
            this.btnMiniApp.Click += new System.EventHandler(this.btnMiniApp_Click);
            // 
            // pnlDrag
            // 
            this.pnlDrag.Controls.Add(this.TitleLabel);
            this.pnlDrag.Controls.Add(this.btnCloseApp);
            this.pnlDrag.Controls.Add(this.btnMiniApp);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(350, 44);
            this.pnlDrag.TabIndex = 1;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
            this.pnlDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseUp);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.TitleLabel.Location = new System.Drawing.Point(12, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(95, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Auto-Clicker";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
            this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // CPSLabel
            // 
            this.CPSLabel.AutoSize = true;
            this.CPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.CPSLabel.Location = new System.Drawing.Point(9, 42);
            this.CPSLabel.Name = "CPSLabel";
            this.CPSLabel.Size = new System.Drawing.Size(153, 16);
            this.CPSLabel.TabIndex = 0;
            this.CPSLabel.Text = "Clicks per Second: 1.000";
            // 
            // posCount
            // 
            this.posCount.AutoSize = true;
            this.posCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.posCount.Location = new System.Drawing.Point(168, 42);
            this.posCount.Name = "posCount";
            this.posCount.Size = new System.Drawing.Size(75, 16);
            this.posCount.TabIndex = 0;
            this.posCount.Text = "Positions: 0";
            // 
            // cursorPos
            // 
            this.cursorPos.AutoSize = true;
            this.cursorPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursorPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.cursorPos.Location = new System.Drawing.Point(253, 65);
            this.cursorPos.Name = "cursorPos";
            this.cursorPos.Size = new System.Drawing.Size(103, 16);
            this.cursorPos.TabIndex = 0;
            this.cursorPos.Text = "Cursor Position: ";
            this.cursorPos.Click += new System.EventHandler(this.posCount_Click);
            // 
            // Xpos
            // 
            this.Xpos.AutoSize = true;
            this.Xpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.Xpos.Location = new System.Drawing.Point(253, 86);
            this.Xpos.Name = "Xpos";
            this.Xpos.Size = new System.Drawing.Size(35, 16);
            this.Xpos.TabIndex = 0;
            this.Xpos.Text = "X = 0";
            this.Xpos.Click += new System.EventHandler(this.posCount_Click);
            // 
            // Ypos
            // 
            this.Ypos.AutoSize = true;
            this.Ypos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ypos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.Ypos.Location = new System.Drawing.Point(302, 86);
            this.Ypos.Name = "Ypos";
            this.Ypos.Size = new System.Drawing.Size(36, 16);
            this.Ypos.TabIndex = 0;
            this.Ypos.Text = "Y = 0";
            this.Ypos.Click += new System.EventHandler(this.posCount_Click);
            // 
            // CPSTextBox
            // 
            this.CPSTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.CPSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.CPSTextBox.Location = new System.Drawing.Point(138, 11);
            this.CPSTextBox.Name = "CPSTextBox";
            this.CPSTextBox.Size = new System.Drawing.Size(108, 22);
            this.CPSTextBox.TabIndex = 1;
            this.CPSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CPSTextBox.TextChanged += new System.EventHandler(this.CPSTextBox_TextChanged);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.btnToggle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnToggle.Location = new System.Drawing.Point(0, 341);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(350, 28);
            this.btnToggle.TabIndex = 2;
            this.btnToggle.Text = "Status: Not Working";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // enable
            // 
            this.enable.AutoSize = true;
            this.enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.enable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.enable.Location = new System.Drawing.Point(12, 61);
            this.enable.Name = "enable";
            this.enable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enable.Size = new System.Drawing.Size(69, 20);
            this.enable.TabIndex = 3;
            this.enable.Text = "Enable";
            this.enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enable.UseVisualStyleBackColor = true;
            // 
            // scp
            // 
            this.scp.AutoSize = true;
            this.scp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.scp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.scp.Location = new System.Drawing.Point(12, 87);
            this.scp.Name = "scp";
            this.scp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scp.Size = new System.Drawing.Size(139, 20);
            this.scp.TabIndex = 3;
            this.scp.Text = "Set Cursor Position";
            this.scp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scp.UseVisualStyleBackColor = true;
            // 
            // btnCPS
            // 
            this.btnCPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.btnCPS.FlatAppearance.BorderSize = 0;
            this.btnCPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnCPS.Location = new System.Drawing.Point(254, 11);
            this.btnCPS.Name = "btnCPS";
            this.btnCPS.Size = new System.Drawing.Size(88, 22);
            this.btnCPS.TabIndex = 4;
            this.btnCPS.Text = "Set CPS";
            this.btnCPS.UseVisualStyleBackColor = false;
            this.btnCPS.Click += new System.EventHandler(this.btnCPS_Click);
            // 
            // btnResetPos
            // 
            this.btnResetPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.btnResetPos.FlatAppearance.BorderSize = 0;
            this.btnResetPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnResetPos.Location = new System.Drawing.Point(254, 39);
            this.btnResetPos.Name = "btnResetPos";
            this.btnResetPos.Size = new System.Drawing.Size(88, 22);
            this.btnResetPos.TabIndex = 4;
            this.btnResetPos.Text = "Reset Positions";
            this.btnResetPos.UseVisualStyleBackColor = false;
            this.btnResetPos.Click += new System.EventHandler(this.btnResetPos_Click);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.panel2);
            this.BodyPanel.Controls.Add(this.panel1);
            this.BodyPanel.Controls.Add(this.AuthorLabel);
            this.BodyPanel.Controls.Add(this.btnSetControls);
            this.BodyPanel.Controls.Add(this.btnResetPos);
            this.BodyPanel.Controls.Add(this.btnCPS);
            this.BodyPanel.Controls.Add(this.onTop);
            this.BodyPanel.Controls.Add(this.scp);
            this.BodyPanel.Controls.Add(this.enable);
            this.BodyPanel.Controls.Add(this.btnToggle);
            this.BodyPanel.Controls.Add(this.CPSTextBox);
            this.BodyPanel.Controls.Add(this.Ypos);
            this.BodyPanel.Controls.Add(this.Xpos);
            this.BodyPanel.Controls.Add(this.cursorPos);
            this.BodyPanel.Controls.Add(this.posCount);
            this.BodyPanel.Controls.Add(this.nrClicksLabel);
            this.BodyPanel.Controls.Add(this.controlsLabel);
            this.BodyPanel.Controls.Add(this.CPSLabel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BodyPanel.Location = new System.Drawing.Point(0, 51);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(350, 369);
            this.BodyPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioNum6);
            this.panel2.Controls.Add(this.radioF7key);
            this.panel2.Controls.Add(this.radioArrowRight);
            this.panel2.Controls.Add(this.SetSetPosLabel);
            this.panel2.Controls.Add(this.setPosLabel);
            this.panel2.Controls.Add(this.SetPosSetLabel);
            this.panel2.Location = new System.Drawing.Point(233, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 164);
            this.panel2.TabIndex = 6;
            // 
            // radioNum6
            // 
            this.radioNum6.AutoSize = true;
            this.radioNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioNum6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.radioNum6.Location = new System.Drawing.Point(9, 72);
            this.radioNum6.Name = "radioNum6";
            this.radioNum6.Size = new System.Drawing.Size(92, 20);
            this.radioNum6.TabIndex = 1;
            this.radioNum6.TabStop = true;
            this.radioNum6.Text = "NumLock 6";
            this.radioNum6.UseVisualStyleBackColor = true;
            // 
            // radioF7key
            // 
            this.radioF7key.AutoSize = true;
            this.radioF7key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioF7key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.radioF7key.Location = new System.Drawing.Point(9, 46);
            this.radioF7key.Name = "radioF7key";
            this.radioF7key.Size = new System.Drawing.Size(66, 20);
            this.radioF7key.TabIndex = 1;
            this.radioF7key.TabStop = true;
            this.radioF7key.Text = "F7 Key";
            this.radioF7key.UseVisualStyleBackColor = true;
            // 
            // radioArrowRight
            // 
            this.radioArrowRight.AutoSize = true;
            this.radioArrowRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioArrowRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.radioArrowRight.Location = new System.Drawing.Point(9, 20);
            this.radioArrowRight.Name = "radioArrowRight";
            this.radioArrowRight.Size = new System.Drawing.Size(93, 20);
            this.radioArrowRight.TabIndex = 1;
            this.radioArrowRight.TabStop = true;
            this.radioArrowRight.Text = "Right Arrow";
            this.radioArrowRight.UseVisualStyleBackColor = true;
            // 
            // SetSetPosLabel
            // 
            this.SetSetPosLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SetSetPosLabel.FlatAppearance.BorderSize = 0;
            this.SetSetPosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSetPosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.SetSetPosLabel.Location = new System.Drawing.Point(0, 126);
            this.SetSetPosLabel.Name = "SetSetPosLabel";
            this.SetSetPosLabel.Size = new System.Drawing.Size(114, 22);
            this.SetSetPosLabel.TabIndex = 4;
            this.SetSetPosLabel.Text = "RIGHT Arrow";
            this.SetSetPosLabel.UseVisualStyleBackColor = false;
            // 
            // setPosLabel
            // 
            this.setPosLabel.AutoSize = true;
            this.setPosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.setPosLabel.Location = new System.Drawing.Point(3, 0);
            this.setPosLabel.Name = "setPosLabel";
            this.setPosLabel.Size = new System.Drawing.Size(78, 16);
            this.setPosLabel.TabIndex = 0;
            this.setPosLabel.Text = "Set Position";
            // 
            // SetPosSetLabel
            // 
            this.SetPosSetLabel.AutoSize = true;
            this.SetPosSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPosSetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.SetPosSetLabel.Location = new System.Drawing.Point(26, 107);
            this.SetPosSetLabel.Name = "SetPosSetLabel";
            this.SetPosSetLabel.Size = new System.Drawing.Size(57, 16);
            this.SetPosSetLabel.TabIndex = 0;
            this.SetPosSetLabel.Text = "Set Pos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioNum8);
            this.panel1.Controls.Add(this.radioF6key);
            this.panel1.Controls.Add(this.radioArrowUp);
            this.panel1.Controls.Add(this.SetOnOffLabel);
            this.panel1.Controls.Add(this.onOffLabel);
            this.panel1.Controls.Add(this.OnOffSetLabel);
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 164);
            this.panel1.TabIndex = 6;
            // 
            // radioNum8
            // 
            this.radioNum8.AutoSize = true;
            this.radioNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioNum8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.radioNum8.Location = new System.Drawing.Point(9, 72);
            this.radioNum8.Name = "radioNum8";
            this.radioNum8.Size = new System.Drawing.Size(92, 20);
            this.radioNum8.TabIndex = 1;
            this.radioNum8.TabStop = true;
            this.radioNum8.Text = "NumLock 8";
            this.radioNum8.UseVisualStyleBackColor = true;
            // 
            // radioF6key
            // 
            this.radioF6key.AutoSize = true;
            this.radioF6key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioF6key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.radioF6key.Location = new System.Drawing.Point(9, 46);
            this.radioF6key.Name = "radioF6key";
            this.radioF6key.Size = new System.Drawing.Size(66, 20);
            this.radioF6key.TabIndex = 1;
            this.radioF6key.TabStop = true;
            this.radioF6key.Text = "F6 Key";
            this.radioF6key.UseVisualStyleBackColor = true;
            // 
            // radioArrowUp
            // 
            this.radioArrowUp.AutoSize = true;
            this.radioArrowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioArrowUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.radioArrowUp.Location = new System.Drawing.Point(9, 20);
            this.radioArrowUp.Name = "radioArrowUp";
            this.radioArrowUp.Size = new System.Drawing.Size(80, 20);
            this.radioArrowUp.TabIndex = 1;
            this.radioArrowUp.TabStop = true;
            this.radioArrowUp.Text = "Up Arrow";
            this.radioArrowUp.UseVisualStyleBackColor = true;
            // 
            // SetOnOffLabel
            // 
            this.SetOnOffLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SetOnOffLabel.FlatAppearance.BorderSize = 0;
            this.SetOnOffLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetOnOffLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.SetOnOffLabel.Location = new System.Drawing.Point(-5, 126);
            this.SetOnOffLabel.Name = "SetOnOffLabel";
            this.SetOnOffLabel.Size = new System.Drawing.Size(114, 22);
            this.SetOnOffLabel.TabIndex = 4;
            this.SetOnOffLabel.Text = "UP Arrow";
            this.SetOnOffLabel.UseVisualStyleBackColor = false;
            // 
            // onOffLabel
            // 
            this.onOffLabel.AutoSize = true;
            this.onOffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onOffLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.onOffLabel.Location = new System.Drawing.Point(3, 0);
            this.onOffLabel.Name = "onOffLabel";
            this.onOffLabel.Size = new System.Drawing.Size(44, 16);
            this.onOffLabel.TabIndex = 0;
            this.onOffLabel.Text = "On/Off";
            // 
            // OnOffSetLabel
            // 
            this.OnOffSetLabel.AutoSize = true;
            this.OnOffSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffSetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.OnOffSetLabel.Location = new System.Drawing.Point(30, 107);
            this.OnOffSetLabel.Name = "OnOffSetLabel";
            this.OnOffSetLabel.Size = new System.Drawing.Size(47, 16);
            this.OnOffSetLabel.TabIndex = 0;
            this.OnOffSetLabel.Text = "On/Off:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.AuthorLabel.Location = new System.Drawing.Point(9, 322);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(178, 16);
            this.AuthorLabel.TabIndex = 5;
            this.AuthorLabel.Text = "Made by Ghita Stefan-Andrei";
            // 
            // btnSetControls
            // 
            this.btnSetControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.btnSetControls.FlatAppearance.BorderSize = 0;
            this.btnSetControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnSetControls.Location = new System.Drawing.Point(133, 155);
            this.btnSetControls.Name = "btnSetControls";
            this.btnSetControls.Size = new System.Drawing.Size(88, 22);
            this.btnSetControls.TabIndex = 4;
            this.btnSetControls.Text = "Set Controls";
            this.btnSetControls.UseVisualStyleBackColor = false;
            this.btnSetControls.Click += new System.EventHandler(this.btnSetControls_Click);
            // 
            // onTop
            // 
            this.onTop.AutoSize = true;
            this.onTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.onTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.onTop.Location = new System.Drawing.Point(12, 113);
            this.onTop.Name = "onTop";
            this.onTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.onTop.Size = new System.Drawing.Size(132, 20);
            this.onTop.TabIndex = 3;
            this.onTop.Text = "App stays on Top";
            this.onTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.onTop.UseVisualStyleBackColor = true;
            // 
            // nrClicksLabel
            // 
            this.nrClicksLabel.AutoSize = true;
            this.nrClicksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrClicksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.nrClicksLabel.Location = new System.Drawing.Point(9, 13);
            this.nrClicksLabel.Name = "nrClicksLabel";
            this.nrClicksLabel.Size = new System.Drawing.Size(117, 16);
            this.nrClicksLabel.TabIndex = 0;
            this.nrClicksLabel.Text = "Insert interval [ms]:";
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(170)))), ((int)(((byte)(76)))));
            this.controlsLabel.Location = new System.Drawing.Point(9, 136);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(80, 16);
            this.controlsLabel.TabIndex = 0;
            this.controlsLabel.Text = "Set controls:";
            // 
            // MainProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 420);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainProcess";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnMiniApp;
        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Label TitleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label CPSLabel;
        private System.Windows.Forms.Label posCount;
        private System.Windows.Forms.Label cursorPos;
        private System.Windows.Forms.Label Xpos;
        private System.Windows.Forms.Label Ypos;
        private System.Windows.Forms.TextBox CPSTextBox;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.CheckBox enable;
        private System.Windows.Forms.CheckBox scp;
        private System.Windows.Forms.Button btnCPS;
        private System.Windows.Forms.Button btnResetPos;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.CheckBox onTop;
        private System.Windows.Forms.Label nrClicksLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioF6key;
        private System.Windows.Forms.RadioButton radioArrowUp;
        private System.Windows.Forms.Label onOffLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioNum6;
        private System.Windows.Forms.RadioButton radioF7key;
        private System.Windows.Forms.RadioButton radioArrowRight;
        private System.Windows.Forms.Label setPosLabel;
        private System.Windows.Forms.RadioButton radioNum8;
        private System.Windows.Forms.Button btnSetControls;
        private System.Windows.Forms.Button SetOnOffLabel;
        private System.Windows.Forms.Label OnOffSetLabel;
        private System.Windows.Forms.Button SetSetPosLabel;
        private System.Windows.Forms.Label SetPosSetLabel;
    }
}

