namespace Imagem
{
    public partial class Form1 : Form
    {
        private string _rotaImagem;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog img = new OpenFileDialog()) {
                    img.Filter = "arquivos jpg (*.jpg)|*.jpg";
                    if (img.ShowDialog() == DialogResult.OK) { 
                        pictureBox1.Load(img.FileName);
                        _rotaImagem = img.FileName;
                    }

}
            }
            catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            txtTexto.Text = OCR.Converter(_rotaImagem);

        }

    }
}