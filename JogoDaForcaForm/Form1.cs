namespace JogoDaForcaForm
{
    public partial class Form1 : Form
    {
        private Forca JogoDaForca;

        public Form1()
        {
            InitializeComponent();

            RegistrarEventos(); 

            JogoDaForca = new Forca();

            ObterPalavraParcial();

            ObterDicaPalavra();
        }     

        private void RegistrarEventos()
        {
            foreach(Button botao in pnlBotoes.Controls)         
                botao.Click += DarPalpite;
            
        }
        private void DarPalpite(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            char palpite = botaoClicado.Text[0];

            if(JogoDaForca.JogadorAcertou(palpite) || JogoDaForca.JogadorPerdeu())
            {
                pnlBotoes.Enabled = false;

                JogoDaForca.mensagemFinal;
            }

            ObterPalavraParcial();
        }
        private void ObterPalavraParcial()
        {
            lblPalavraSecreta.Text = JogoDaForca.PalavraParcial;

        }
        private void ObterDicaPalavra()
        {
            lblDica.Text = JogoDaForca.QuantidadeLetras + " letras";
        }
    }
}