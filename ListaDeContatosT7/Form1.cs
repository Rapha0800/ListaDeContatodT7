using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Um vetor de contatos
        private Contato[] contatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escreverEmArquivo = new StreamWriter("Contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }

            escreverEmArquivo.Close();

        }

        private void Ler()
        {
            StreamReader lerAquivo = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(lerAquivo.ReadLine())];

            for (int x = 0; x < contatos.Length; x++)
            {
                contatos[x] = new Contato();
                contatos[x].Nome = lerAquivo.ReadLine();
                contatos[x].Sobrenome = lerAquivo.ReadLine();
                contatos[x].Telefone = lerAquivo.ReadLine();
            }

            lerAquivo.Close ();
        }

        private void Exibir() 
        {
            //limpa a lista de contatos
            listBoxContatos.Items.Clear();
            for (int x = 0; x < contatos.Length; x++) 
            {
                listBoxContatos.Items.Add(contatos[x].ToString());
            }
        }

        private void LimparFormulario()
        {
            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            textBoxTelefone.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cria um objeto da classe contato
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            //listBoxContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Exibir();
            LimparFormulario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir ();
        }
    }
}
