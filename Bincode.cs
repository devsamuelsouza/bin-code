namespace BinCode
{
    public partial class Bincode : Form
    {
        public Bincode()
        {
            InitializeComponent();
        }

        private void Converter_Click(object sender, EventArgs e)
        {
            if (Select1.Text == Select2.Text)
            {
                string message = $"Não é possivel converter de {Select1.Text} para {Select2.Text}!";
                MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Select1.Text == "Texto")
            {
                var output = "";
                foreach (char c in Input.Text)
                {
                    string binario = Convert.ToString(c, 2).PadLeft(8, '0');
                    output += binario + " ";
                }
                Output.Text = output.ToString();
                return;
            }
            else
            {
                try
                {
                    string output = "";
                    string binario = Input.Text.Replace(" ", "");

                    for (int i = 0; i <= binario.Length - 8; i += 8)
                    {
                        string byteString = binario.Substring(i, 8); 
                        int asciiCode = Convert.ToInt32(byteString, 2); 
                        char letra = (char)asciiCode; 
                        output += letra;
                    }

                    Output.Text = output;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Select1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Select1.Text == "Texto")
            {
                Select2.Text = "Binario";
                Input.Text = string.Empty;
                Output.Text = string.Empty;
            }
            else
            {
                Select2.Text = "Texto";
                Input.Text = string.Empty;
                Output.Text = string.Empty;
            }
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Select1.Text == "Binario")
            {
                if (e.KeyChar != 0 && e.KeyChar != 1 && e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void Output_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
