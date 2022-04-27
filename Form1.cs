using System.Text;

namespace Third
{
    public partial class Form1 : Form
    {
        private EncryptionResult encryptionResult = new EncryptionResult();

        public Form1()
        {
            InitializeComponent();
        }

        private void encodeClick(object sender, EventArgs e)
        {
            encryptionResult = Encryption.Encrypt(Convert.ToInt32(textBoxP.Text), Convert.ToInt32(textBoxQ.Text), textBoxX.Text, xLabel);
            yLabel.Text = $"{encryptionResult.Cipher.ToString()}";

            Tuple<int, int> publicKey = new Tuple<int, int>(encryptionResult.N, encryptionResult.E);
            int privateKey = encryptionResult.D;

            kPubLabel.Text = $"{publicKey.Item1}, {publicKey.Item2}";
            kPrivLabel.Text = $"{privateKey}";
        }

        private void decode_Click(object sender, EventArgs e)
        {
            xLabel.Text = Encryption.Decrypt(encryptionResult);
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveYClicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save text file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();


                byte[] bytes = Encoding.UTF8.GetBytes(yLabel.Text);

                fs.Write(bytes, 0, bytes.Length);

                fs.Close();
            }
        }

        private void saveKPubClicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save text file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();


                byte[] bytes = Encoding.UTF8.GetBytes(kPubLabel.Text);

                fs.Write(bytes, 0, bytes.Length);

                fs.Close();
            }
        }

        private void saveKPrivClicked(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save text file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();


                byte[] bytes = Encoding.UTF8.GetBytes(kPrivLabel.Text);

                fs.Write(bytes, 0, bytes.Length);

                fs.Close();
            }
        }

        private void loadYClicked(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            yLabel.Text = fileContent;

            List<string> result = fileContent.Split(' ').ToList();

            Cipher cipher = new Cipher();

            for (int i = 0; i < result.Count; i++)
            {
                cipher.AddValue(int.Parse(result[i]));
            }

         

            encryptionResult.Cipher = cipher;
        }

        private void loadKPubClicked(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            kPubLabel.Text = fileContent;

            List<string> result = fileContent.Split(',').ToList();

            encryptionResult.N = Convert.ToInt32(result[0]);
            encryptionResult.E = Convert.ToInt32(result[1]);
        }

        private void loadKPrivClicked(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
           
            kPrivLabel.Text = fileContent;

            encryptionResult.D = int.Parse(fileContent);
        }
    }
}