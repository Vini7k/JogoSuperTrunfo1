using System;

namespace JogoSuperTrunfo1
{
    public partial class Form1 : Form
    {
        private List<CartaCarro> cartasCarros, cartasMaquina, cartasJogador;
        public Form1()
        {
            InitializeComponent();
            cartasCarros = new List<CartaCarro>();
            CarregarCartas();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CarregarCartas()
        {
            CartaCarro carta1 = new CartaCarro()
            {
                Nome = "Chevrolet Kadett",
                Potencia = 98,
                Torque = 14.6f,
                VelocidadeMaxima = 174,
                Peso = 1000,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta1.png"
            };
            cartasCarros.Add(carta1);

            CartaCarro carta2 = new CartaCarro()
            {
                Nome = "Ford Escort",
                Potencia = 74,
                Torque = 12.6f,
                VelocidadeMaxima = 157,
                Peso = 880,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta2.png"
            };
            cartasCarros.Add(carta2);

            CartaCarro carta3 = new CartaCarro()
            {
                Nome = "Chevrolet Suprema",
                Potencia = 168,
                Torque = 29.1f,
                VelocidadeMaxima = 215,
                Peso = 1550,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta3.png"
            };
            cartasCarros.Add(carta3);

            CartaCarro carta4 = new CartaCarro()
            {
                Nome = "Volvo 960 Wagon",
                Potencia = 181,
                Torque = 27.5f,
                VelocidadeMaxima = 200,
                Peso = 1570,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta4.png"
            };
            cartasCarros.Add(carta4);

            CartaCarro carta5 = new CartaCarro()
            {
                Nome = "Chevrolet Opala",
                Potencia = 171,
                Torque = 32.5f,
                VelocidadeMaxima = 190,
                Peso = 1100,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta5.png"
            };
            cartasCarros.Add(carta5);

            CartaCarro carta6 = new CartaCarro()
            {
                Nome = "Ford Maverick",
                Potencia = 197,
                Torque = 30.5f,
                VelocidadeMaxima = 182,
                Peso = 1390,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta6.png"
            };
            cartasCarros.Add(carta6);

            CartaCarro carta7 = new CartaCarro()
            {
                Nome = "Chevrolet Astra",
                Potencia = 136,
                Torque = 19.2f,
                VelocidadeMaxima = 203,
                Peso = 1180,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta7.png"
            };
            cartasCarros.Add(carta7);

            CartaCarro carta8 = new CartaCarro()
            {
                Nome = "Citroen C4 Vtr",
                Potencia = 143,
                Torque = 20.4f,
                VelocidadeMaxima = 207,
                Peso = 1288,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta8.png"
            };
            cartasCarros.Add(carta8);

            CartaCarro carta9 = new CartaCarro()
            {
                Nome = "Chevrolet Montana Sport",
                Potencia = 114,
                Torque = 17.7f,
                VelocidadeMaxima = 181,
                Peso = 1116,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta9.png"
            };
            cartasCarros.Add(carta9);

            CartaCarro carta10 = new CartaCarro()
            {
                Nome = "Fiat Strada Sport",
                Potencia = 132,
                Torque = 18.9f,
                VelocidadeMaxima = 184,
                Peso = 1138,
                Imagem = "E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\carta10.png"
            };
            cartasCarros.Add(carta10);

        }
        private void quantidadeCartas()
        {
            foreach (var carta in cartasMaquina)
            {
                int quantidade1 = cartasMaquina.Count;
                lblCartasMaquina.Text = quantidade1.ToString();
            }
            foreach (var carta in cartasJogador)
            {
                int quantidade2 = cartasJogador.Count;
                lblCartasJogador.Text = quantidade2.ToString();
            }
        }
        private void sortearCartas()
        {
            cartasMaquina = new List<CartaCarro>();
            cartasJogador = new List<CartaCarro>();
            Random rnd = new Random();
            bool vezJogador = true;
            while (cartasCarros.Count > 0)
            {
                int posicao = rnd.Next(cartasCarros.Count);
                if (vezJogador)
                {
                    cartasJogador.Add(cartasCarros[posicao]);
                    cartasCarros.Remove(cartasCarros[posicao]);
                    vezJogador = false;
                    continue;
                }
                cartasMaquina.Add(cartasCarros[posicao]);
                cartasCarros.Remove(cartasCarros[posicao]);
                vezJogador = true;
            }
        }
        /* private void proximaRodada()
         {
             Random random = new Random();
             int index1 = random.Next(cartasJogador.Count);
             int index2 = random.Next(cartasMaquina.Count);

             CartaCarro cartaJogada1 = cartasJogador[index1];
             CartaCarro cartaJogada2 = cartasMaquina[index2];
             pictureBox1.Image = Image.FromFile(cartaJogada1.Imagem);
             pictureBox1.Tag = index1;

             Adiciona o verso da carta ao picturebox2:
             pictureBox2.Image = Image.FromFile("F:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\cartaVerso.png");
         }*/
        private void proximaRodadaJogador()
        {
            Random random = new Random();
            int index1 = random.Next(cartasJogador.Count);

            CartaCarro cartaJogada1 = cartasJogador[index1];
            pictureBox1.Image = Image.FromFile(cartaJogada1.Imagem);
            pictureBox1.Tag = index1;

        }
        private void proximaRodadaMaquina()
        {

            Random random = new Random();
            int index2 = random.Next(cartasMaquina.Count);

            CartaCarro cartaJogada2 = cartasMaquina[index2];
            pictureBox2.Tag = index2;
            pictureBox2.Image = Image.FromFile("E:\\Escola\\windows forms\\JogoSuperTrunfo1\\Imagens\\cartaVerso.png");
        }
        private void acabaJogo()
        {
            if (cartasMaquina.Count == 0)
            {
                MessageBox.Show("VOCE GANHOU O JOGO");
                Application.Exit();
            }
            if (cartasJogador.Count == 0)
            {
                MessageBox.Show("VOCE PERDEU O JOGO");
                Application.Exit();
            }
        }
        private void compararCartas()
        {
            int index1 = (int)pictureBox1.Tag;
            int index2 = (int)pictureBox2.Tag;

            CartaCarro cartaJogada1 = cartasJogador[index1];
            CartaCarro cartaJogada2 = cartasMaquina[index2];

            List<RadioButton> listaAtributos = new List<RadioButton>
            {
                Atributo1,
                Atributo2,
                Atributo3,
                Atributo4,
            };

            if (listaAtributos[0].Checked)
            {

                if (cartaJogada1.VelocidadeMaxima > cartaJogada2.VelocidadeMaxima)
                {
                    pictureBox2.Image = Image.FromFile(cartaJogada2.Imagem);
                    MessageBox.Show("você venceu");
                    cartasJogador.Add(cartasMaquina[index2]);
                    cartasMaquina.Remove(cartasMaquina[index2]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaJogador();
                    proximaRodadaMaquina();

                }
                else if (cartaJogada1.VelocidadeMaxima == cartaJogada2.VelocidadeMaxima)
                {
                    MessageBox.Show("empate");
                    proximaRodadaJogador();
                    proximaRodadaMaquina();
                }
                else
                {
                    MessageBox.Show("você perdeu");
                    cartasMaquina.Add(cartasJogador[index1]);
                    cartasJogador.Remove(cartasJogador[index1]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }

            }
            if (listaAtributos[1].Checked)
            {

                if (cartaJogada1.Potencia > cartaJogada2.Potencia)
                {
                    pictureBox2.Image = Image.FromFile(cartaJogada2.Imagem);
                    MessageBox.Show("você venceu");
                    cartasJogador.Add(cartasMaquina[index2]);
                    cartasMaquina.Remove(cartasMaquina[index2]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
                else if (cartaJogada1.Potencia == cartaJogada2.Potencia)
                {
                    MessageBox.Show("empate");
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
                else
                {
                    MessageBox.Show("você perdeu");
                    cartasMaquina.Add(cartasJogador[index1]);
                    cartasJogador.Remove(cartasJogador[index1]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }

            }
            if (listaAtributos[2].Checked)
            {

                if (cartaJogada1.Peso < cartaJogada2.Peso)
                {
                    pictureBox2.Image = Image.FromFile(cartaJogada2.Imagem);
                    MessageBox.Show("você venceu");
                    cartasJogador.Add(cartasMaquina[index2]);
                    cartasMaquina.Remove(cartasMaquina[index2]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
                else if (cartaJogada1.Peso == cartaJogada2.Peso)
                {
                    MessageBox.Show("empate");
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
                else
                {
                    MessageBox.Show("você perdeu");
                    cartasMaquina.Add(cartasJogador[index1]);
                    cartasJogador.Remove(cartasJogador[index1]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }

            }
            if (listaAtributos[3].Checked)
            {

                if (cartaJogada1.Torque > cartaJogada2.Torque)
                {
                    pictureBox2.Image = Image.FromFile(cartaJogada2.Imagem);
                    MessageBox.Show("você venceu");
                    cartasJogador.Add(cartasMaquina[index2]);
                    cartasMaquina.Remove(cartasMaquina[index2]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
                else if (cartaJogada1.Torque == cartaJogada2.Torque)
                {
                    MessageBox.Show("empate");
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
                else
                {
                    MessageBox.Show("você perdeu");
                    cartasMaquina.Add(cartasJogador[index1]);
                    cartasJogador.Remove(cartasJogador[index1]);
                    quantidadeCartas();
                    acabaJogo();
                    proximaRodadaMaquina();
                    proximaRodadaJogador();
                }
            }
        }
        private void sortearCartaJogada()
        {
            Random random = new Random();
            int index1 = random.Next(cartasJogador.Count);
            int index2 = random.Next(cartasMaquina.Count);

            CartaCarro cartaJogada1 = cartasJogador[index1];
            CartaCarro cartaJogada2 = cartasMaquina[index2];

            pictureBox1.Image = Image.FromFile(cartaJogada1.Imagem);
            pictureBox1.Tag = index1;

            pictureBox2.Tag = index2;
        }
        private void botaoSortear_Click(object sender, EventArgs e)
        {
            sortearCartas();
            quantidadeCartas();
            botaoSortear.Enabled = false;
        }
        private void botaoSortearJogada_Click(object sender, EventArgs e)
        {
            sortearCartaJogada();
            botaoSortearJogada.Enabled = false;
        }
        private void botaoComparar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("MOSTRE UMA CARTA ANTES DE COMPARAR");
                return;
            }
            else
            {
                compararCartas();

            }
        }
    }
}