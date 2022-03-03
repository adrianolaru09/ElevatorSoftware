namespace ElevatorSoftware_Adrian
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_Down = new System.Windows.Forms.Button();
            this.lbl_Floor1 = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.btn_Floor0_panel = new System.Windows.Forms.Button();
            this.btn_Floor1_panel = new System.Windows.Forms.Button();
            this.lbl_Control = new System.Windows.Forms.Label();
            this.lbl_ControlPanel = new System.Windows.Forms.Label();
            this.Floor1 = new System.Windows.Forms.Panel();
            this.p_RightDoor = new System.Windows.Forms.PictureBox();
            this.p_LeftDoor = new System.Windows.Forms.PictureBox();
            this.btn_Up = new System.Windows.Forms.Button();
            this.lbl_Floor0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_Events = new System.Windows.Forms.ListBox();
            this.lbl_Events = new System.Windows.Forms.Label();
            this.btn_LoadEvents = new System.Windows.Forms.Button();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.tmr_Anim = new System.Windows.Forms.Timer(this.components);
            this.ControlPanel.SuspendLayout();
            this.Floor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_RightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_LeftDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(305, 144);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(75, 23);
            this.btn_Down.TabIndex = 2;
            this.btn_Down.Text = "Call";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // lbl_Floor1
            // 
            this.lbl_Floor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Floor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Floor1.Location = new System.Drawing.Point(309, 30);
            this.lbl_Floor1.Name = "lbl_Floor1";
            this.lbl_Floor1.Size = new System.Drawing.Size(60, 36);
            this.lbl_Floor1.TabIndex = 4;
            this.lbl_Floor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Floor1.Click += new System.EventHandler(this.lbl_Floor1_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ControlPanel.Controls.Add(this.btn_Floor0_panel);
            this.ControlPanel.Controls.Add(this.btn_Floor1_panel);
            this.ControlPanel.Controls.Add(this.lbl_Control);
            this.ControlPanel.Controls.Add(this.lbl_ControlPanel);
            this.ControlPanel.Location = new System.Drawing.Point(36, 153);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(155, 213);
            this.ControlPanel.TabIndex = 6;
            // 
            // btn_Floor0_panel
            // 
            this.btn_Floor0_panel.Location = new System.Drawing.Point(41, 154);
            this.btn_Floor0_panel.Name = "btn_Floor0_panel";
            this.btn_Floor0_panel.Size = new System.Drawing.Size(75, 23);
            this.btn_Floor0_panel.TabIndex = 3;
            this.btn_Floor0_panel.Text = "0";
            this.btn_Floor0_panel.UseVisualStyleBackColor = true;
            this.btn_Floor0_panel.Click += new System.EventHandler(this.btn_Floor0_panel_Click);
            // 
            // btn_Floor1_panel
            // 
            this.btn_Floor1_panel.Location = new System.Drawing.Point(41, 117);
            this.btn_Floor1_panel.Name = "btn_Floor1_panel";
            this.btn_Floor1_panel.Size = new System.Drawing.Size(75, 23);
            this.btn_Floor1_panel.TabIndex = 2;
            this.btn_Floor1_panel.Text = "1";
            this.btn_Floor1_panel.UseVisualStyleBackColor = true;
            this.btn_Floor1_panel.Click += new System.EventHandler(this.btn_Floor1_panel_Click);
            // 
            // lbl_Control
            // 
            this.lbl_Control.AutoSize = true;
            this.lbl_Control.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Control.Location = new System.Drawing.Point(62, 57);
            this.lbl_Control.Name = "lbl_Control";
            this.lbl_Control.Size = new System.Drawing.Size(0, 24);
            this.lbl_Control.TabIndex = 1;
            this.lbl_Control.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Control.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ControlPanel
            // 
            this.lbl_ControlPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_ControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControlPanel.Location = new System.Drawing.Point(24, 12);
            this.lbl_ControlPanel.Name = "lbl_ControlPanel";
            this.lbl_ControlPanel.Size = new System.Drawing.Size(110, 26);
            this.lbl_ControlPanel.TabIndex = 0;
            this.lbl_ControlPanel.Text = "ControlPanel";
            this.lbl_ControlPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ControlPanel.Click += new System.EventHandler(this.lbl_ControlPanel_Click);
            // 
            // Floor1
            // 
            this.Floor1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Floor1.Controls.Add(this.p_RightDoor);
            this.Floor1.Controls.Add(this.p_LeftDoor);
            this.Floor1.Controls.Add(this.btn_Up);
            this.Floor1.Controls.Add(this.lbl_Floor0);
            this.Floor1.Controls.Add(this.btn_Down);
            this.Floor1.Controls.Add(this.lbl_Floor1);
            this.Floor1.Controls.Add(this.label2);
            this.Floor1.Location = new System.Drawing.Point(242, 45);
            this.Floor1.Name = "Floor1";
            this.Floor1.Size = new System.Drawing.Size(395, 469);
            this.Floor1.TabIndex = 7;
            this.Floor1.Paint += new System.Windows.Forms.PaintEventHandler(this.Floor1_Paint);
            // 
            // p_RightDoor
            // 
            this.p_RightDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_RightDoor.Location = new System.Drawing.Point(146, 304);
            this.p_RightDoor.Name = "p_RightDoor";
            this.p_RightDoor.Padding = new System.Windows.Forms.Padding(150);
            this.p_RightDoor.Size = new System.Drawing.Size(74, 122);
            this.p_RightDoor.TabIndex = 7;
            this.p_RightDoor.TabStop = false;
            this.p_RightDoor.Click += new System.EventHandler(this.p_RightDoor_Click);
            // 
            // p_LeftDoor
            // 
            this.p_LeftDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_LeftDoor.Location = new System.Drawing.Point(77, 304);
            this.p_LeftDoor.Name = "p_LeftDoor";
            this.p_LeftDoor.Padding = new System.Windows.Forms.Padding(150);
            this.p_LeftDoor.Size = new System.Drawing.Size(74, 122);
            this.p_LeftDoor.TabIndex = 6;
            this.p_LeftDoor.TabStop = false;
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(305, 403);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(75, 23);
            this.btn_Up.TabIndex = 3;
            this.btn_Up.Text = "Call";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // lbl_Floor0
            // 
            this.lbl_Floor0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Floor0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Floor0.Location = new System.Drawing.Point(309, 252);
            this.lbl_Floor0.Name = "lbl_Floor0";
            this.lbl_Floor0.Size = new System.Drawing.Size(60, 36);
            this.lbl_Floor0.TabIndex = 5;
            this.lbl_Floor0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Floor0.Click += new System.EventHandler(this.lbl_Floor0_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lst_Events
            // 
            this.lst_Events.BackColor = System.Drawing.SystemColors.Window;
            this.lst_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Events.FormattingEnabled = true;
            this.lst_Events.HorizontalScrollbar = true;
            this.lst_Events.ItemHeight = 16;
            this.lst_Events.Location = new System.Drawing.Point(697, 153);
            this.lst_Events.Name = "lst_Events";
            this.lst_Events.Size = new System.Drawing.Size(389, 212);
            this.lst_Events.TabIndex = 9;
            this.lst_Events.SelectedIndexChanged += new System.EventHandler(this.lst_Events_SelectedIndexChanged);
            // 
            // lbl_Events
            // 
            this.lbl_Events.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Events.Location = new System.Drawing.Point(738, 114);
            this.lbl_Events.Name = "lbl_Events";
            this.lbl_Events.Size = new System.Drawing.Size(110, 26);
            this.lbl_Events.TabIndex = 4;
            this.lbl_Events.Text = "Events history";
            this.lbl_Events.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LoadEvents
            // 
            this.btn_LoadEvents.Location = new System.Drawing.Point(697, 389);
            this.btn_LoadEvents.Name = "btn_LoadEvents";
            this.btn_LoadEvents.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadEvents.TabIndex = 10;
            this.btn_LoadEvents.Text = "Load Events";
            this.btn_LoadEvents.UseVisualStyleBackColor = true;
            this.btn_LoadEvents.Click += new System.EventHandler(this.btn_LoadEvents_Click);
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(808, 389);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearLog.TabIndex = 11;
            this.btn_ClearLog.Text = "Clear List";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // tmr_Anim
            // 
            this.tmr_Anim.Enabled = true;
            this.tmr_Anim.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 563);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.btn_LoadEvents);
            this.Controls.Add(this.lbl_Events);
            this.Controls.Add(this.lst_Events);
            this.Controls.Add(this.Floor1);
            this.Controls.Add(this.ControlPanel);
            this.Name = "Form1";
            this.Text = "AdrianOlaru-ElevatorSoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.Floor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_RightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_LeftDoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Label lbl_Floor1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel Floor1;
        private System.Windows.Forms.Label lbl_ControlPanel;
        private System.Windows.Forms.Button btn_Floor0_panel;
        private System.Windows.Forms.Button btn_Floor1_panel;
        private System.Windows.Forms.Label lbl_Control;
        private System.Windows.Forms.ListBox lst_Events;
        private System.Windows.Forms.Label lbl_Events;
        private System.Windows.Forms.Button btn_LoadEvents;
        private System.Windows.Forms.Button btn_ClearLog;
        private System.Windows.Forms.Timer tmr_Anim;
        private System.Windows.Forms.Label lbl_Floor0;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.PictureBox p_LeftDoor;
        private System.Windows.Forms.PictureBox p_RightDoor;
        private System.Windows.Forms.Label label2;
    }
}

