namespace ControlSystemsProjectSFG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SolveBtn = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddEdgeBtn = new System.Windows.Forms.Button();
            this.AddNodeBtn = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pathsList = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loopsList = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TFText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.Tools.SuspendLayout();
            this.DrawingPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SolveBtn);
            this.panel1.Controls.Add(this.Tools);
            this.panel1.Location = new System.Drawing.Point(1302, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 481);
            this.panel1.TabIndex = 1;
            // 
            // SolveBtn
            // 
            this.SolveBtn.Location = new System.Drawing.Point(17, 431);
            this.SolveBtn.Name = "SolveBtn";
            this.SolveBtn.Size = new System.Drawing.Size(171, 34);
            this.SolveBtn.TabIndex = 1;
            this.SolveBtn.Text = "Solve";
            this.SolveBtn.UseVisualStyleBackColor = true;
            this.SolveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.ClearBtn);
            this.Tools.Controls.Add(this.EndBtn);
            this.Tools.Controls.Add(this.StartBtn);
            this.Tools.Controls.Add(this.EditBtn);
            this.Tools.Controls.Add(this.DeleteBtn);
            this.Tools.Controls.Add(this.AddEdgeBtn);
            this.Tools.Controls.Add(this.AddNodeBtn);
            this.Tools.Location = new System.Drawing.Point(17, 12);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(171, 400);
            this.Tools.TabIndex = 0;
            this.Tools.TabStop = false;
            this.Tools.Text = "Tools";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(18, 212);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(135, 39);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(18, 343);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(135, 39);
            this.EndBtn.TabIndex = 5;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(18, 298);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(135, 39);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(18, 167);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(135, 39);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(18, 122);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(135, 39);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddEdgeBtn
            // 
            this.AddEdgeBtn.Location = new System.Drawing.Point(18, 77);
            this.AddEdgeBtn.Name = "AddEdgeBtn";
            this.AddEdgeBtn.Size = new System.Drawing.Size(135, 39);
            this.AddEdgeBtn.TabIndex = 1;
            this.AddEdgeBtn.Text = "Add Edge";
            this.AddEdgeBtn.UseVisualStyleBackColor = true;
            this.AddEdgeBtn.Click += new System.EventHandler(this.AddEdgeBtn_Click);
            // 
            // AddNodeBtn
            // 
            this.AddNodeBtn.Location = new System.Drawing.Point(18, 32);
            this.AddNodeBtn.Name = "AddNodeBtn";
            this.AddNodeBtn.Size = new System.Drawing.Size(135, 39);
            this.AddNodeBtn.TabIndex = 0;
            this.AddNodeBtn.Text = "Add Node";
            this.AddNodeBtn.UseVisualStyleBackColor = true;
            this.AddNodeBtn.Click += new System.EventHandler(this.AddNodeBtn_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.Info;
            this.DrawingPanel.Controls.Add(this.label1);
            this.DrawingPanel.Controls.Add(this.InputTxt);
            this.DrawingPanel.Location = new System.Drawing.Point(1, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1295, 481);
            this.DrawingPanel.TabIndex = 4;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1131, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // InputTxt
            // 
            this.InputTxt.Enabled = false;
            this.InputTxt.Location = new System.Drawing.Point(1134, 23);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(148, 20);
            this.InputTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pathsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths";
            // 
            // pathsList
            // 
            this.pathsList.FullRowSelect = true;
            this.pathsList.Location = new System.Drawing.Point(6, 19);
            this.pathsList.Name = "pathsList";
            this.pathsList.Size = new System.Drawing.Size(479, 129);
            this.pathsList.TabIndex = 0;
            this.pathsList.UseCompatibleStateImageBehavior = false;
            this.pathsList.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loopsList);
            this.groupBox3.Location = new System.Drawing.Point(509, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 154);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loops";
            // 
            // loopsList
            // 
            this.loopsList.FullRowSelect = true;
            this.loopsList.Location = new System.Drawing.Point(6, 19);
            this.loopsList.Name = "loopsList";
            this.loopsList.Size = new System.Drawing.Size(479, 129);
            this.loopsList.TabIndex = 1;
            this.loopsList.UseCompatibleStateImageBehavior = false;
            this.loopsList.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TFText);
            this.groupBox4.Location = new System.Drawing.Point(1006, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 154);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer Function";
            // 
            // TFText
            // 
            this.TFText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TFText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFText.Location = new System.Drawing.Point(6, 19);
            this.TFText.Name = "TFText";
            this.TFText.Size = new System.Drawing.Size(475, 129);
            this.TFText.TabIndex = 3;
            this.TFText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1502, 647);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Tools.ResumeLayout(false);
            this.DrawingPanel.ResumeLayout(false);
            this.DrawingPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.Button SolveBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddEdgeBtn;
        private System.Windows.Forms.Button AddNodeBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.ListView pathsList;
        private System.Windows.Forms.ListView loopsList;
        private System.Windows.Forms.RichTextBox TFText;
    }
}

