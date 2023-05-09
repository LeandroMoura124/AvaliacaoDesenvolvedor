using Microsoft.IdentityModel.Xml;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;

namespace AvaliacaoDesenvolvedor
{
    public partial class Form1 : Form
    {
        //armazenando o link img em uma variável
        public const string imageUrl = "https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png";
        public const string imageFilePath = @"C:\Image\redeservice-logo.png";



        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Salvando os valores digitados e adicionando os mesmos na listbox*/
            string valor;

            valor = textBox1.Text.ToString();

            listaNumeros.Items.Add(valor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Ordenando valores*/

            string[] a = listaNumeros.Items.Cast<string>().ToArray();

            listaNumeros.Items.Clear();

            var ord = a.OrderBy(x => int.Parse(x));

            foreach (var item in ord)
            {
                listaNumeros.Items.Add(item.ToString());
            }

            // Gravando os números em um arquivo de texto
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + "numeros_ordenar.txt";
            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                foreach (var item in ord)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Abrir arquivo de texto*/
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "numeros_ordenar.txt");
            if (File.Exists(caminhoArquivo))
            {
                Process.Start("notepad.exe", caminhoArquivo);
            }
            else
            {
                MessageBox.Show("O arquivo não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            listEnd.Items.Clear();
        }



        private async void ConsultaBanco_Click(object sender, EventArgs e)
        {
            //retornando os dados da API para o Grid após clicar no button
            dataGridView1.DataSource = await ConsultaAPI();
        }
        //Consumindo a API
        private async Task<List<Banco>> ConsultaAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://brasilapi.com.br/api/banks/v1");
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();

                List<Banco> bancos = JsonConvert.DeserializeObject<List<Banco>>(jsonString);

                return bancos;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());

                        listEnd.Items.Clear();
                        //dados do endereço que serão retornados
                        listEnd.Items.Add("Endereço: " + endereco.end);
                        listEnd.Items.Add("Bairro: " + endereco.bairro);
                        listEnd.Items.Add("Cep: " + endereco.cep);
                        listEnd.Items.Add("Complemento2: " + endereco.complemento2);
                        listEnd.Items.Add("Unidade de Postagem: " + endereco.unidadesPostagem);
                        listEnd.Items.Add("Cidade: " + endereco.cidade);
                        listEnd.Items.Add("Estado: " + endereco.uf);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {

                Directory.CreateDirectory(Path.GetDirectoryName(imageFilePath)); //se a pasta nao existir

                client.DownloadFile(imageUrl, imageFilePath);
            }
            var imageBytes = File.ReadAllBytes(imageFilePath);
            var base64String = Convert.ToBase64String(imageBytes);

            LeIMG.Items.Add(base64String);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            List<clsTeste> listaTeste = new List<clsTeste>();
            for (int i = 1; i <= 100; i++)
            {

                clsTeste objetoTeste = new clsTeste();

                objetoTeste.codigo = i;

                // Usando Datetime
                objetoTeste.descricao = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");

                // Add
                listaTeste.Add(objetoTeste);
            }
            // Converte a lista de objetos da classe clsTeste para uma string JSON
            string json = JsonConvert.SerializeObject(listaTeste, Formatting.Indented);

            // Escreve a string JSON em um arquivo chamado data.json na pasta raiz da aplicação
            File.WriteAllText("data.json", json);

            MessageBox.Show("Dados salvos em data.json.");

        }

        private void CarregarJson_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("data.json"))
            {
                // Lê o conteúdo do arquivo data.json e converte para uma lista de objetos da classe clsTeste
                string json = File.ReadAllText("data.json");
                List<clsTeste> listaTeste = JsonConvert.DeserializeObject<List<clsTeste>>(json);

                ListImg64.Rows.Clear();

                //colunas
                ListImg64.Columns.Add("codigo", "Código");
                ListImg64.Columns.Add("descricao", "Descrição");

                // Carrega no dados base64 no List
                foreach (clsTeste objetoTeste in listaTeste)
                {
                    ListImg64.Rows.Add(objetoTeste.codigo, objetoTeste.descricao);
                }
            }
            //se o arquivo json não existir
            else
            {
                MessageBox.Show("Arquivo data.json não encontrado.");
            }
        }
    }
}



