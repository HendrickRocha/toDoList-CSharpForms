namespace toDoList
{
    partial class toDoList_form
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
            this.date_dp = new System.Windows.Forms.DateTimePicker();
            this.toDos_lb = new System.Windows.Forms.ListBox();
            this.deleteTask_btn = new System.Windows.Forms.Button();
            this.addTask_btn = new System.Windows.Forms.Button();
            this.date_lbl = new System.Windows.Forms.Label();
            this.task_lbl = new System.Windows.Forms.Label();
            this.dateToolTip_tt = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.task_txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // date_dp
            // 
            this.date_dp.Location = new System.Drawing.Point(14, 72);
            this.date_dp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_dp.Name = "date_dp";
            this.date_dp.Size = new System.Drawing.Size(263, 21);
            this.date_dp.TabIndex = 0;
            this.dateToolTip_tt.SetToolTip(this.date_dp, "Digite a data da tarefa");
            this.date_dp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // toDos_lb
            // 
            this.toDos_lb.AccessibleDescription = "";
            this.toDos_lb.FormattingEnabled = true;
            this.toDos_lb.ItemHeight = 15;
            this.toDos_lb.Location = new System.Drawing.Point(12, 217);
            this.toDos_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toDos_lb.Name = "toDos_lb";
            this.toDos_lb.Size = new System.Drawing.Size(408, 289);
            this.toDos_lb.TabIndex = 2;
            this.toDos_lb.SelectedIndexChanged += new System.EventHandler(this.toDos_lb_SelectedIndexChanged);
            // 
            // deleteTask_btn
            // 
            this.deleteTask_btn.Enabled = false;
            this.deleteTask_btn.Location = new System.Drawing.Point(332, 183);
            this.deleteTask_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteTask_btn.Name = "deleteTask_btn";
            this.deleteTask_btn.Size = new System.Drawing.Size(87, 26);
            this.deleteTask_btn.TabIndex = 3;
            this.deleteTask_btn.Text = "Remover";
            this.deleteTask_btn.UseVisualStyleBackColor = true;
            this.deleteTask_btn.Click += new System.EventHandler(this.deleteTask_btn_Click);
            // 
            // addTask_btn
            // 
            this.addTask_btn.Location = new System.Drawing.Point(14, 183);
            this.addTask_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addTask_btn.Name = "addTask_btn";
            this.addTask_btn.Size = new System.Drawing.Size(87, 26);
            this.addTask_btn.TabIndex = 4;
            this.addTask_btn.Text = "Incluir";
            this.addTask_btn.UseVisualStyleBackColor = true;
            this.addTask_btn.Click += new System.EventHandler(this.addTask_btn_Click);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(12, 52);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(42, 16);
            this.date_lbl.TabIndex = 5;
            this.date_lbl.Text = "Data";
            // 
            // task_lbl
            // 
            this.task_lbl.AutoSize = true;
            this.task_lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_lbl.Location = new System.Drawing.Point(11, 121);
            this.task_lbl.Name = "task_lbl";
            this.task_lbl.Size = new System.Drawing.Size(56, 16);
            this.task_lbl.TabIndex = 6;
            this.task_lbl.Text = "Tarefa";
            // 
            // dateToolTip_tt
            // 
            this.dateToolTip_tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dateToolTip_tt.ToolTipTitle = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "To Do List";
            // 
            // task_txtb
            // 
            this.task_txtb.Location = new System.Drawing.Point(15, 141);
            this.task_txtb.Name = "task_txtb";
            this.task_txtb.Size = new System.Drawing.Size(260, 21);
            this.task_txtb.TabIndex = 8;
            // 
            // toDoList_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 519);
            this.Controls.Add(this.task_txtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.addTask_btn);
            this.Controls.Add(this.deleteTask_btn);
            this.Controls.Add(this.toDos_lb);
            this.Controls.Add(this.date_dp);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "toDoList_form";
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.toDoList_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_dp;
        private System.Windows.Forms.ListBox toDos_lb;
        private System.Windows.Forms.Button deleteTask_btn;
        private System.Windows.Forms.Button addTask_btn;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label task_lbl;
        private System.Windows.Forms.ToolTip dateToolTip_tt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox task_txtb;
    }
}

