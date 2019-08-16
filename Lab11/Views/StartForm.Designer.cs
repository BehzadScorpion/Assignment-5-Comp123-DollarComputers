namespace DollarComputers.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.ExitTheProgramButton = new System.Windows.Forms.Button();
            this.LoadASavedOrderButton = new System.Windows.Forms.Button();
            this.StartANewOrderButton = new System.Windows.Forms.Button();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonsTable.SuspendLayout();
            this.MainTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsTable
            // 
            this.ButtonsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonsTable.AutoSize = true;
            this.ButtonsTable.ColumnCount = 1;
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTable.Controls.Add(this.ExitTheProgramButton, 0, 2);
            this.ButtonsTable.Controls.Add(this.LoadASavedOrderButton, 0, 1);
            this.ButtonsTable.Controls.Add(this.StartANewOrderButton, 0, 0);
            this.ButtonsTable.Location = new System.Drawing.Point(44, 80);
            this.ButtonsTable.Name = "ButtonsTable";
            this.ButtonsTable.RowCount = 3;
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTable.Size = new System.Drawing.Size(272, 240);
            this.ButtonsTable.TabIndex = 0;
            // 
            // ExitTheProgramButton
            // 
            this.ExitTheProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ExitTheProgramButton.AutoSize = true;
            this.ExitTheProgramButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitTheProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTheProgramButton.Location = new System.Drawing.Point(24, 163);
            this.ExitTheProgramButton.Name = "ExitTheProgramButton";
            this.ExitTheProgramButton.Size = new System.Drawing.Size(224, 74);
            this.ExitTheProgramButton.TabIndex = 2;
            this.ExitTheProgramButton.Text = "Exit the Program";
            this.ExitTheProgramButton.UseVisualStyleBackColor = false;
            this.ExitTheProgramButton.Click += new System.EventHandler(this.ExitTheProgramButton_Click);
            // 
            // LoadASavedOrderButton
            // 
            this.LoadASavedOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoadASavedOrderButton.AutoSize = true;
            this.LoadASavedOrderButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoadASavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadASavedOrderButton.Location = new System.Drawing.Point(3, 83);
            this.LoadASavedOrderButton.Name = "LoadASavedOrderButton";
            this.LoadASavedOrderButton.Size = new System.Drawing.Size(266, 74);
            this.LoadASavedOrderButton.TabIndex = 1;
            this.LoadASavedOrderButton.Text = "Load a Saved Order";
            this.LoadASavedOrderButton.UseVisualStyleBackColor = false;
            this.LoadASavedOrderButton.Click += new System.EventHandler(this.LoadASavedOrderButton_Click);
            // 
            // StartANewOrderButton
            // 
            this.StartANewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StartANewOrderButton.AutoSize = true;
            this.StartANewOrderButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartANewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartANewOrderButton.Location = new System.Drawing.Point(15, 3);
            this.StartANewOrderButton.Name = "StartANewOrderButton";
            this.StartANewOrderButton.Size = new System.Drawing.Size(242, 74);
            this.StartANewOrderButton.TabIndex = 0;
            this.StartANewOrderButton.Text = "Start a New Order";
            this.StartANewOrderButton.UseVisualStyleBackColor = false;
            this.StartANewOrderButton.Click += new System.EventHandler(this.StartANewOrderButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTable.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.MainTable.Controls.Add(this.ButtonsTable, 0, 0);
            this.MainTable.Location = new System.Drawing.Point(92, 93);
            this.MainTable.Margin = new System.Windows.Forms.Padding(5);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(600, 400);
            this.MainTable.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(363, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 394);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.MainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.ButtonsTable.ResumeLayout(false);
            this.ButtonsTable.PerformLayout();
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonsTable;
        private System.Windows.Forms.Button ExitTheProgramButton;
        private System.Windows.Forms.Button LoadASavedOrderButton;
        private System.Windows.Forms.Button StartANewOrderButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

