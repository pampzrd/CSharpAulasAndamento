using System;
using System.Windows.Forms;

namespace GeradorDeBiscoitoDaSorte
{
    public partial class BiscoitoDaSorte : Form
    {
        //Variáveis
        string[] frases = { "Você não morrerá \nenquanto estiver vivo.", "As flores florecem\n ao florecer.", "Toda a sabedoria é sábia","A cada dia que se vai, \nmenos você vive.","Chespirito era um gênio, \nmas você nem.","Cada gota de orvalho \npela manhã é molhada.","O silêncio é silencioso.","Você deve entrar pela porta,\n e sair pela janela.","Pela tarde todo sol \né torrante.","Tome seu café de hoje.","Para tocar basta \naprender um instrumento.", "Quando a chuva passar,abra a \n janela e veja a roupa no varal." };
        Random rnd = new Random();

        public BiscoitoDaSorte()
        { InitializeComponent();}

        private void lblTitulo_Click(object sender, EventArgs e){}

        private void btnFechar_Click(object sender, EventArgs e)
        {Environment.Exit(0);}

        
        private void btnSorteio_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            lblMensagem.Text = frases[numRnd()];
        }

        public int numRnd()
        {
            int numFrases = frases.Length;
            int sorteador = Convert.ToInt32(rnd.Next(1, numFrases));
            return sorteador;
        }

        private void pic01_Click(object sender, EventArgs e){}

    }
}
