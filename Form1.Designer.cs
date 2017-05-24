namespace TCPKlient
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
            this.adres = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.polacz = new System.Windows.Forms.Button();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(31, 12);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(288, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "adres";
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.ItemHeight = 20;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(31, 49);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(642, 404);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // polacz
            // 
            this.polacz.Location = new System.Drawing.Point(260, 467);
            this.polacz.Name = "polacz";
            this.polacz.Size = new System.Drawing.Size(189, 51);
            this.polacz.TabIndex = 3;
            this.polacz.Text = "Połącz";
            this.polacz.UseVisualStyleBackColor = true;
            this.polacz.Click += new System.EventHandler(this.polacz_Click);
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(356, 13);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(317, 20);
            this.my_port.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 530);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button polacz;
        private System.Windows.Forms.NumericUpDown my_port;
    }
}

