using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodeGen0._0._0._1
{
    public partial class Form1 : Form
    {
        private byte[] decrypt_data = new byte[1024];
        private byte[] encrypt_data = new byte[1024];
        private bool decrypt_file_filled = false;
        private bool encrypt_file_filled = false;
        public Form1()
        {
            InitializeComponent();
            data_Input.Enabled = true;
            encrypt_fileopen_btn.Enabled = false;
        }
        private void encrypt_click(object sender, EventArgs e)
        {
            if (data_Input.Text != "" && encrypt_password.Text != ""||encrypt_file_filled==true)
            {
                if (radio_text.Checked)
                {
                    encrypt_data = Encoding.UTF8.GetBytes(data_Input.Text);
                }
                byte[] encrypted_data = Crypto.Encrypt(encrypt_data, encrypt_password.Text);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "저장";
                DialogResult res = sfd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        string dir = sfd.FileName;
                        FileStream file = new FileStream(dir, FileMode.Create);
                        file.Write(encrypted_data, 0, encrypted_data.Length);
                        file.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("패스워드 또는 암호화할 내용을 입력하세요");
            }
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 열기";
            ofd.Filter = "텍스트 (*.txt) | *.txt";
            if (decrypt_file_filled == true)
            {
                byte[] decrypted_data = Crypto.Decrypt(decrypt_data, decrypt_password.Text);
                if (decrypted_data == decrypt_data)
                {
                    MessageBox.Show("비밀번호가 틀립니다.");
                }
                decrypted_output.Text = Encoding.UTF8.GetString(decrypted_data);
            }
            else
            {
                MessageBox.Show("암호화할 파일을 불러오세요");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "복호화할 파일 열기";
            ofd.Filter = "모든 파일 (*.*) | *.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                decrypt_data = File.ReadAllBytes(ofd.FileName);
                decrypt_file_filled = true;
                file_status_label.Text = "파일 로드됨";
            }
        }

        private void unload_file_button_Click(object sender, EventArgs e)
        {
            Array.Clear(decrypt_data, 0, decrypt_data.Length);
            decrypt_file_filled = false;
            file_status_label.Text = "파일 언로드됨";
        }

        private void radio_text_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_text.Checked==true)
            {
                data_Input.Enabled = true;
                encrypt_fileopen_btn.Enabled = false;
            }
        }

        private void radio_file_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_file.Checked==true)
            {
                data_Input.Enabled = false;
                encrypt_fileopen_btn.Enabled = true;
            }
        }

        private void encrypt_fileopen_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "암호화할 파일 열기";
            ofd.Filter = "텍스트 (*.txt) | *.txt";
            DialogResult res = ofd.ShowDialog();
            if(res==DialogResult.OK)
            {
                encrypt_data = File.ReadAllBytes(ofd.FileName);
                encrypt_file_filled = true;
                encrypt_filestatus_label.Text = "파일 로드됨";
            }
        }

        private void encrypt_file_unload_btn_Click(object sender, EventArgs e)
        {
            Array.Clear(encrypt_data, 0, decrypt_data.Length);
            encrypt_file_filled = false;
            encrypt_filestatus_label.Text = "파일 언로드됨";
        }

        private void decrypted_save_btn_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "복호화된 파일 저장";
            save.Filter = "텍스트(*.txt)|*.txt";
            save.DefaultExt = "txt";
            if(save.ShowDialog() == DialogResult.OK)
            {
                filename = save.FileName;
                File.WriteAllText(filename, decrypted_output.Text);
            }
        }

        private void ViewBtn_MouseDown(object sender, MouseEventArgs e)
        {
            encrypt_password.PasswordChar = default(char);
        }

        private void ViewBtn_MouseUp(object sender, MouseEventArgs e)
        {
            encrypt_password.PasswordChar = '●';
        }

        private void ViewBtn_MouseLeave(object sender, EventArgs e)
        {
            encrypt_password.PasswordChar = '●';
        }

        private void dec_ps_viewbtn_MouseDown(object sender, MouseEventArgs e)
        {
            decrypt_password.PasswordChar = default(char);
        }

        private void dec_ps_viewbtn_MouseUp(object sender, MouseEventArgs e)
        {
            decrypt_password.PasswordChar = '●';
        }

        private void dec_ps_viewbtn_MouseLeave(object sender, EventArgs e)
        {
            decrypt_password.PasswordChar = '●';
        }
    }
}
