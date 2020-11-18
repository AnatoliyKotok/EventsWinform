namespace WinformEvents
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btAddEvent = new System.Windows.Forms.Button();
            this.comboBoxLevelImp = new System.Windows.Forms.ComboBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.btClearList = new System.Windows.Forms.Button();
            this.btDelSelected = new System.Windows.Forms.Button();
            this.btFindEv = new System.Windows.Forms.Button();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(292, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter name for event";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btAddEvent
            // 
            this.btAddEvent.Location = new System.Drawing.Point(12, 151);
            this.btAddEvent.Name = "btAddEvent";
            this.btAddEvent.Size = new System.Drawing.Size(112, 37);
            this.btAddEvent.TabIndex = 4;
            this.btAddEvent.Tag = "Hight";
            this.btAddEvent.Text = "Add event";
            this.btAddEvent.UseVisualStyleBackColor = true;
            this.btAddEvent.Click += new System.EventHandler(this.btAddEvent_Click);
            // 
            // comboBoxLevelImp
            // 
            this.comboBoxLevelImp.FormattingEnabled = true;
            this.comboBoxLevelImp.Items.AddRange(new object[] {
            "Low",
            "Avarage",
            "High"});
            this.comboBoxLevelImp.Location = new System.Drawing.Point(12, 110);
            this.comboBoxLevelImp.Name = "comboBoxLevelImp";
            this.comboBoxLevelImp.Size = new System.Drawing.Size(145, 21);
            this.comboBoxLevelImp.TabIndex = 7;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(456, 9);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(332, 394);
            this.listBoxEvents.TabIndex = 8;
            // 
            // btClearList
            // 
            this.btClearList.Location = new System.Drawing.Point(12, 366);
            this.btClearList.Name = "btClearList";
            this.btClearList.Size = new System.Drawing.Size(84, 37);
            this.btClearList.TabIndex = 9;
            this.btClearList.Text = "Clear list";
            this.btClearList.UseVisualStyleBackColor = true;
            this.btClearList.Click += new System.EventHandler(this.btClearList_Click);
            // 
            // btDelSelected
            // 
            this.btDelSelected.Location = new System.Drawing.Point(102, 366);
            this.btDelSelected.Name = "btDelSelected";
            this.btDelSelected.Size = new System.Drawing.Size(88, 37);
            this.btDelSelected.TabIndex = 10;
            this.btDelSelected.Text = "Delete selected";
            this.btDelSelected.UseVisualStyleBackColor = true;
            this.btDelSelected.Click += new System.EventHandler(this.btDelSelected_Click);
            // 
            // btFindEv
            // 
            this.btFindEv.Location = new System.Drawing.Point(196, 366);
            this.btFindEv.Name = "btFindEv";
            this.btFindEv.Size = new System.Drawing.Size(87, 37);
            this.btFindEv.TabIndex = 11;
            this.btFindEv.Text = "Find event";
            this.btFindEv.UseVisualStyleBackColor = true;
            this.btFindEv.Click += new System.EventHandler(this.btFindEv_Click);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(12, 260);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(186, 20);
            this.textBoxFName.TabIndex = 12;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(289, 366);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(84, 37);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save in file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.btFindEv);
            this.Controls.Add(this.btDelSelected);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.comboBoxLevelImp);
            this.Controls.Add(this.btAddEvent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btAddEvent;
        private System.Windows.Forms.ComboBox comboBoxLevelImp;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button btClearList;
        private System.Windows.Forms.Button btDelSelected;
        private System.Windows.Forms.Button btFindEv;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button1;
    }
}

