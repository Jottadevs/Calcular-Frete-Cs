namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool aereo, terrestre;

            if (checkBAreo.Checked) { aereo = true; } else { aereo = false; }
            if (checkBTerrestre.Checked) { terrestre = true; } else { terrestre = false; }

            bool sp, mg, rs;

            if (checkBox1.Checked) { sp = true; } else { sp = false; }
            if (checkBox2.Checked) { mg = true; } else { mg = false; }
            if (checkBox3.Checked) { rs = true; } else { rs = false; }

            string nomeProd = textBox1.Text,
                   nomeDest = textBox3.Text,
                   telDest = textBox4.Text,
                   endDest = textBox5.Text;

            if (aereo == false && terrestre == false)
            {
                MessageBox.Show("Preencha um tipo de transporte");
            }
            else if (sp == false || mg == false || rs == false)
            {
                MessageBox.Show("Preencha um local [SP, MG ou RS]");
            }
            else if(string.IsNullOrEmpty(nomeProd) || string.IsNullOrEmpty(nomeDest) || string.IsNullOrEmpty(telDest) || string.IsNullOrEmpty(endDest))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                double frete, peso;

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Insira um peso");
                }
                else
                {
                    peso = Convert.ToDouble(textBox2.Text);

                    //Calculo do frete aereo
                    if (aereo == true)
                    {
                        if (sp == true)
                        {
                            frete = 0.10 * (peso * 100);
                            textBoxRES.Text = $"{nomeDest} seu produto [ {nomeProd} ] recebe o frete de: {frete} Reais" + Environment.NewLine +
                                $"Infos: Destino SP por meio Aéreo" + Environment.NewLine +
                                $"Seu numero: {telDest}" + Environment.NewLine +
                                $"Seu endereço: {endDest}";
                        }
                        else if (mg == true)
                        {
                            frete = 0.25 * (peso * 100);
                            textBoxRES.Text = $"{nomeDest} seu produto [ {nomeProd} ] recebe o frete de: {frete} Reais " + Environment.NewLine +
                                $"Infos: Destino MG por meio Aéreo" + Environment.NewLine +
                                $"Seu numero: {telDest}" + Environment.NewLine +
                                $"Seu endereço: {endDest}";
                        }
                        else if (rs == true)
                        {
                            frete = 0.15 * (peso * 100);
                            textBoxRES.Text = $"{nomeDest} seu produto [ {nomeProd} ] recebe o frete de: {frete} Reais " + Environment.NewLine +
                                $"Infos: Destino RS por meio Aéreo," + Environment.NewLine +
                                $"Seu numero: {telDest}" + Environment.NewLine +
                                $"Seu endereço: {endDest}";
                        }
                    }

                    // Calculo do frete terrestre
                    if (terrestre == true)
                    {
                        if (sp == true)
                        {
                            frete = 0.05 * (peso * 100);
                            textBoxRES.Text = $"{nomeDest} seu produto [ {nomeProd} ] recebe o frete de: {frete} Reais " + Environment.NewLine +
                                $"Infos: Destino SP por meio Terrestre" + Environment.NewLine +
                                $"Seu numero: {telDest}" + Environment.NewLine +
                                $"Seu endereço: {endDest}";
                        }
                        else if (mg == true)
                        {
                            frete = 0.20 * (peso * 100);
                            textBoxRES.Text = $"{nomeDest} seu produto [ {nomeProd} ] recebe o frete de: {frete} Reais" + Environment.NewLine +
                                $"Infos: Destino MG por meio Terrestre" + Environment.NewLine +
                                $"Seu numero: {telDest}" + Environment.NewLine +
                                $"Seu endereço: {endDest}";
                        }
                        else if (rs == true)
                        {
                            frete = 0.10 * (peso * 100);
                            textBoxRES.Text = $"{nomeDest} seu produto [ {nomeProd} ] recebe o frete de: {frete} Reais" + Environment.NewLine +
                                $"Infos: Destino RS por meio Terrestre" + Environment.NewLine +
                                $"Seu numero: {telDest}" + Environment.NewLine +
                                $"Seu endereço: {endDest}";
                        }
                    }
                }
            }
        }
    }
}