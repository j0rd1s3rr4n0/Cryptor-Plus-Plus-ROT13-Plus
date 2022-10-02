namespace EncriptadorGrafico
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.crypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rotacion = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result_tbox = new System.Windows.Forms.TextBox();
            this.j0rd1s3rr4n0 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // crypt
            // 
            this.crypt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.crypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crypt.BackgroundImage = global::EncriptadorGrafico.Properties.Resources.crypt;
            this.crypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crypt.Location = new System.Drawing.Point(743, 35);
            this.crypt.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.crypt.Name = "crypt";
            this.crypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crypt.Size = new System.Drawing.Size(159, 145);
            this.crypt.TabIndex = 0;
            this.crypt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crypt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.crypt.UseVisualStyleBackColor = true;
            this.crypt.UseWaitCursor = true;
            this.crypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // decrypt
            // 
            this.decrypt.BackgroundImage = global::EncriptadorGrafico.Properties.Resources.decrypt;
            this.decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decrypt.Location = new System.Drawing.Point(743, 239);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(159, 141);
            this.decrypt.TabIndex = 1;
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // input_text
            // 
            this.input_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_text.Location = new System.Drawing.Point(53, 52);
            this.input_text.Multiline = true;
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(662, 111);
            this.input_text.TabIndex = 2;
            this.input_text.TextChanged += new System.EventHandler(this.input_text_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "INTRODUCIR TEXTO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "RESULTADO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "ROTACION:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rotacion
            // 
            this.rotacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rotacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rotacion.Location = new System.Drawing.Point(53, 201);
            this.rotacion.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.rotacion.Name = "rotacion";
            this.rotacion.Size = new System.Drawing.Size(139, 34);
            this.rotacion.TabIndex = 9;
            this.rotacion.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.rotacion.ValueChanged += new System.EventHandler(this.rotacion_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(782, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Crypt";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(782, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "DeCrypt";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // result_tbox
            // 
            this.result_tbox.Location = new System.Drawing.Point(53, 311);
            this.result_tbox.Multiline = true;
            this.result_tbox.Name = "result_tbox";
            this.result_tbox.Size = new System.Drawing.Size(662, 119);
            this.result_tbox.TabIndex = 12;
            // 
            // j0rd1s3rr4n0
            // 
            this.j0rd1s3rr4n0.AutoSize = true;
            this.j0rd1s3rr4n0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.j0rd1s3rr4n0.LinkColor = System.Drawing.Color.Black;
            this.j0rd1s3rr4n0.Location = new System.Drawing.Point(724, 446);
            this.j0rd1s3rr4n0.Name = "j0rd1s3rr4n0";
            this.j0rd1s3rr4n0.Size = new System.Drawing.Size(212, 23);
            this.j0rd1s3rr4n0.TabIndex = 13;
            this.j0rd1s3rr4n0.TabStop = true;
            this.j0rd1s3rr4n0.Text = "Coded By @j0rd1s3rr4n0";
            this.j0rd1s3rr4n0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.j0rd1s3rr4n0.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(936, 478);
            this.Controls.Add(this.j0rd1s3rr4n0);
            this.Controls.Add(this.result_tbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rotacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.crypt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptor++ ROT13+   ";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button crypt;
        private Button decrypt;
        private TextBox input_text;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown rotacion;
        private Label label4;
        private Label label5;
        private TextBox result_tbox;
        private LinkLabel j0rd1s3rr4n0;
    }
}