namespace CodeGen0._0._0._1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.data_Input = new System.Windows.Forms.TextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.encrypt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.crypt = new System.Windows.Forms.TabPage();
            this.encrypt_file_unload_btn = new System.Windows.Forms.Button();
            this.encrypt_filestatus_label = new System.Windows.Forms.Label();
            this.encrypt_fileopen_btn = new System.Windows.Forms.Button();
            this.radio_file = new System.Windows.Forms.RadioButton();
            this.radio_text = new System.Windows.Forms.RadioButton();
            this.decrypt = new System.Windows.Forms.TabPage();
            this.decrypted_output = new System.Windows.Forms.TextBox();
            this.file_status_label = new System.Windows.Forms.Label();
            this.unload_file_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypt_password = new System.Windows.Forms.TextBox();
            this.decrypted_save_btn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.PictureBox();
            this.dec_ps_viewbtn = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.crypt.SuspendLayout();
            this.decrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec_ps_viewbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Input
            // 
            this.data_Input.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.data_Input.Location = new System.Drawing.Point(8, 34);
            this.data_Input.Name = "data_Input";
            this.data_Input.Size = new System.Drawing.Size(505, 26);
            this.data_Input.TabIndex = 0;
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.Location = new System.Drawing.Point(6, 19);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(32, 12);
            this.Input_label.TabIndex = 1;
            this.Input_label.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "output";
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(8, 281);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(196, 113);
            this.encrypt_btn.TabIndex = 4;
            this.encrypt_btn.Text = "암호화";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_click);
            // 
            // encrypt_password
            // 
            this.encrypt_password.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.encrypt_password.Location = new System.Drawing.Point(8, 174);
            this.encrypt_password.Name = "encrypt_password";
            this.encrypt_password.PasswordChar = '●';
            this.encrypt_password.Size = new System.Drawing.Size(505, 26);
            this.encrypt_password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "password";
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(566, 281);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(196, 113);
            this.decrypt_btn.TabIndex = 7;
            this.decrypt_btn.Text = "복호화";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.crypt);
            this.tabControl1.Controls.Add(this.decrypt);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 8;
            // 
            // crypt
            // 
            this.crypt.Controls.Add(this.ViewBtn);
            this.crypt.Controls.Add(this.encrypt_file_unload_btn);
            this.crypt.Controls.Add(this.encrypt_filestatus_label);
            this.crypt.Controls.Add(this.encrypt_fileopen_btn);
            this.crypt.Controls.Add(this.radio_file);
            this.crypt.Controls.Add(this.radio_text);
            this.crypt.Controls.Add(this.data_Input);
            this.crypt.Controls.Add(this.Input_label);
            this.crypt.Controls.Add(this.encrypt_btn);
            this.crypt.Controls.Add(this.label2);
            this.crypt.Controls.Add(this.encrypt_password);
            this.crypt.Location = new System.Drawing.Point(4, 22);
            this.crypt.Name = "crypt";
            this.crypt.Padding = new System.Windows.Forms.Padding(3);
            this.crypt.Size = new System.Drawing.Size(768, 400);
            this.crypt.TabIndex = 0;
            this.crypt.Text = "암호화";
            this.crypt.UseVisualStyleBackColor = true;
            // 
            // encrypt_file_unload_btn
            // 
            this.encrypt_file_unload_btn.Location = new System.Drawing.Point(319, 79);
            this.encrypt_file_unload_btn.Name = "encrypt_file_unload_btn";
            this.encrypt_file_unload_btn.Size = new System.Drawing.Size(136, 62);
            this.encrypt_file_unload_btn.TabIndex = 11;
            this.encrypt_file_unload_btn.Text = "파일 언로드";
            this.encrypt_file_unload_btn.UseVisualStyleBackColor = true;
            this.encrypt_file_unload_btn.Click += new System.EventHandler(this.encrypt_file_unload_btn_Click);
            // 
            // encrypt_filestatus_label
            // 
            this.encrypt_filestatus_label.AutoSize = true;
            this.encrypt_filestatus_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.encrypt_filestatus_label.Location = new System.Drawing.Point(157, 98);
            this.encrypt_filestatus_label.Name = "encrypt_filestatus_label";
            this.encrypt_filestatus_label.Size = new System.Drawing.Size(129, 19);
            this.encrypt_filestatus_label.TabIndex = 10;
            this.encrypt_filestatus_label.Text = "파일 언로드됨";
            // 
            // encrypt_fileopen_btn
            // 
            this.encrypt_fileopen_btn.Location = new System.Drawing.Point(6, 79);
            this.encrypt_fileopen_btn.Name = "encrypt_fileopen_btn";
            this.encrypt_fileopen_btn.Size = new System.Drawing.Size(136, 62);
            this.encrypt_fileopen_btn.TabIndex = 9;
            this.encrypt_fileopen_btn.Text = "파일 불러오기";
            this.encrypt_fileopen_btn.UseVisualStyleBackColor = true;
            this.encrypt_fileopen_btn.Click += new System.EventHandler(this.encrypt_fileopen_btn_Click);
            // 
            // radio_file
            // 
            this.radio_file.AutoSize = true;
            this.radio_file.Location = new System.Drawing.Point(8, 243);
            this.radio_file.Name = "radio_file";
            this.radio_file.Size = new System.Drawing.Size(47, 16);
            this.radio_file.TabIndex = 8;
            this.radio_file.Text = "파일";
            this.radio_file.UseVisualStyleBackColor = true;
            this.radio_file.CheckedChanged += new System.EventHandler(this.radio_file_CheckedChanged);
            // 
            // radio_text
            // 
            this.radio_text.AutoSize = true;
            this.radio_text.Checked = true;
            this.radio_text.Location = new System.Drawing.Point(8, 221);
            this.radio_text.Name = "radio_text";
            this.radio_text.Size = new System.Drawing.Size(59, 16);
            this.radio_text.TabIndex = 7;
            this.radio_text.TabStop = true;
            this.radio_text.Text = "텍스트";
            this.radio_text.UseVisualStyleBackColor = true;
            this.radio_text.CheckedChanged += new System.EventHandler(this.radio_text_CheckedChanged);
            // 
            // decrypt
            // 
            this.decrypt.Controls.Add(this.dec_ps_viewbtn);
            this.decrypt.Controls.Add(this.decrypted_output);
            this.decrypt.Controls.Add(this.file_status_label);
            this.decrypt.Controls.Add(this.unload_file_button);
            this.decrypt.Controls.Add(this.button1);
            this.decrypt.Controls.Add(this.label3);
            this.decrypt.Controls.Add(this.decrypt_password);
            this.decrypt.Controls.Add(this.decrypted_save_btn);
            this.decrypt.Controls.Add(this.decrypt_btn);
            this.decrypt.Controls.Add(this.label1);
            this.decrypt.Location = new System.Drawing.Point(4, 22);
            this.decrypt.Name = "decrypt";
            this.decrypt.Padding = new System.Windows.Forms.Padding(3);
            this.decrypt.Size = new System.Drawing.Size(768, 400);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "복호화";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // decrypted_output
            // 
            this.decrypted_output.Location = new System.Drawing.Point(9, 158);
            this.decrypted_output.Multiline = true;
            this.decrypted_output.Name = "decrypted_output";
            this.decrypted_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decrypted_output.Size = new System.Drawing.Size(504, 117);
            this.decrypted_output.TabIndex = 13;
            // 
            // file_status_label
            // 
            this.file_status_label.AutoSize = true;
            this.file_status_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.file_status_label.Location = new System.Drawing.Point(6, 85);
            this.file_status_label.Name = "file_status_label";
            this.file_status_label.Size = new System.Drawing.Size(108, 16);
            this.file_status_label.TabIndex = 12;
            this.file_status_label.Text = "파일 언로드됨";
            // 
            // unload_file_button
            // 
            this.unload_file_button.Location = new System.Drawing.Point(277, 281);
            this.unload_file_button.Name = "unload_file_button";
            this.unload_file_button.Size = new System.Drawing.Size(196, 113);
            this.unload_file_button.TabIndex = 11;
            this.unload_file_button.Text = "파일 언로드";
            this.unload_file_button.UseVisualStyleBackColor = true;
            this.unload_file_button.Click += new System.EventHandler(this.unload_file_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 113);
            this.button1.TabIndex = 10;
            this.button1.Text = "파일 로드";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "password";
            // 
            // decrypt_password
            // 
            this.decrypt_password.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.decrypt_password.Location = new System.Drawing.Point(8, 41);
            this.decrypt_password.Name = "decrypt_password";
            this.decrypt_password.PasswordChar = '●';
            this.decrypt_password.Size = new System.Drawing.Size(505, 26);
            this.decrypt_password.TabIndex = 8;
            // 
            // decrypted_save_btn
            // 
            this.decrypted_save_btn.Location = new System.Drawing.Point(519, 158);
            this.decrypted_save_btn.Name = "decrypted_save_btn";
            this.decrypted_save_btn.Size = new System.Drawing.Size(196, 65);
            this.decrypted_save_btn.TabIndex = 7;
            this.decrypted_save_btn.Text = "저장";
            this.decrypted_save_btn.UseVisualStyleBackColor = true;
            this.decrypted_save_btn.Click += new System.EventHandler(this.decrypted_save_btn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Image = global::CodeGen0._0._0._2.Properties.Resources.view;
            this.ViewBtn.Location = new System.Drawing.Point(519, 174);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(27, 26);
            this.ViewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ViewBtn.TabIndex = 12;
            this.ViewBtn.TabStop = false;
            this.ViewBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewBtn_MouseDown);
            this.ViewBtn.MouseLeave += new System.EventHandler(this.ViewBtn_MouseLeave);
            this.ViewBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewBtn_MouseUp);
            // 
            // dec_ps_viewbtn
            // 
            this.dec_ps_viewbtn.Image = global::CodeGen0._0._0._2.Properties.Resources.view;
            this.dec_ps_viewbtn.Location = new System.Drawing.Point(519, 41);
            this.dec_ps_viewbtn.Name = "dec_ps_viewbtn";
            this.dec_ps_viewbtn.Size = new System.Drawing.Size(27, 26);
            this.dec_ps_viewbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dec_ps_viewbtn.TabIndex = 14;
            this.dec_ps_viewbtn.TabStop = false;
            this.dec_ps_viewbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dec_ps_viewbtn_MouseDown);
            this.dec_ps_viewbtn.MouseLeave += new System.EventHandler(this.dec_ps_viewbtn_MouseLeave);
            this.dec_ps_viewbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dec_ps_viewbtn_MouseUp);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Version.Location = new System.Drawing.Point(742, 12);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(41, 12);
            this.Version.TabIndex = 13;
            this.Version.Text = "0.0.0.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crypto";
            this.tabControl1.ResumeLayout(false);
            this.crypt.ResumeLayout(false);
            this.crypt.PerformLayout();
            this.decrypt.ResumeLayout(false);
            this.decrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec_ps_viewbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_Input;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.TextBox encrypt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage crypt;
        private System.Windows.Forms.TabPage decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decrypt_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label file_status_label;
        private System.Windows.Forms.Button unload_file_button;
        private System.Windows.Forms.RadioButton radio_file;
        private System.Windows.Forms.RadioButton radio_text;
        private System.Windows.Forms.Label encrypt_filestatus_label;
        private System.Windows.Forms.Button encrypt_fileopen_btn;
        private System.Windows.Forms.Button encrypt_file_unload_btn;
        private System.Windows.Forms.TextBox decrypted_output;
        private System.Windows.Forms.Button decrypted_save_btn;
        private System.Windows.Forms.PictureBox ViewBtn;
        private System.Windows.Forms.PictureBox dec_ps_viewbtn;
        private System.Windows.Forms.Label Version;
    }
}

