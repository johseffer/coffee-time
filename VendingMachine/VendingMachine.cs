using System;
using System.Drawing;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class frmVendingMachine : Form
    {
        public frmVendingMachine()
        {
            InitializeComponent();
        }

        private double totalInserido;
        private double totalProdutoSelecionado;
        private double totalTroco;

        private int quantidadeMoedasDeUmrealDoTroco = 0;
        private int quantidadeMoedasDeCinquentaCentavosDoTroco = 0;
        private int quantidadeMoedasDeVinteCincoCentavosDoTroco = 0;
        private int quantidadeMoedasDeDezCentavosDoTroco = 0;
        private int quantidadeMoedasDeCincoCentavosDoTroco = 0;

        private void frmVendingMachine_Load(object sender, EventArgs e)
        {
            totalInserido = 0;
            totalProdutoSelecionado = 0;
        }

        private void btnCafeComLeite_Click(object sender, EventArgs e)
        {
            totalProdutoSelecionado = 3;
            onProdutoSelecionado();
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            totalProdutoSelecionado = 3.5;
            onProdutoSelecionado();
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            totalProdutoSelecionado = 4;
            onProdutoSelecionado();
        }

        private void pbUmCentavo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erro na leitora!");
        }

        private void pbCincoCentavos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erro na leitora!");
        }

        private void pbDezCentavos_Click(object sender, EventArgs e)
        {
            totalInserido += 0.10;
            onClickMoeda();
        }

        private void pbVinteCincoCentavos_Click(object sender, EventArgs e)
        {
            totalInserido += 0.25;
            onClickMoeda();
        }

        private void pbCinquentaCentavos_Click(object sender, EventArgs e)
        {
            totalInserido += 0.50;
            onClickMoeda();
        }

        private void pbUmReal_Click(object sender, EventArgs e)
        {
            totalInserido += 1;
            onClickMoeda();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FinalizaAOperacao($"Compra realizada, seu troco ficou no valor de {totalTroco.ToString("N2")}. Aproveite seu café!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CalcularQuantidadeDeMoedasDoTroco(totalInserido);
            FinalizaAOperacao($"Compra cancelada, devolvendo valor total de R$ {totalInserido.ToString("N2")}.");
        }

        private void onClickMoeda()
        {
            flpTroco.Controls.Clear();
            AtualizarLabelDeValorInserido();
            HabilitarBotoesDeSelecaoDoProduto();
            HabilitarBotaoCancelar();
        }

        private void onProdutoSelecionado()
        {
            AtualizarLabelDeTotal();
            AtualizarLabelDeTroco();

            btnComprar.Enabled = true;
        }

        private void AtualizarLabelDeValorInserido()
        {
            lblValorInserido.Text = $"R$ {totalInserido.ToString("N2")}";
        }

        private void AtualizarLabelDeTotal()
        {
            lblValorTotal.Text = $"R$ {totalProdutoSelecionado.ToString("N2")}";
        }

        private void AtualizarLabelDeTroco()
        {
            totalTroco = totalInserido > 0 ? Math.Round(totalProdutoSelecionado - totalInserido, 2) : 0;
            totalTroco = totalTroco < 0 ? totalTroco * -1 : totalTroco;
            lblTroco.Text = $"R$ {(totalTroco).ToString("N2")}";

            CalcularQuantidadeDeMoedasDoTroco(totalTroco);
        }

        private void CalcularQuantidadeDeMoedasDoTroco(double troco)
        {
            while (troco > 0)
            {
                if (troco >= 1)
                {
                    quantidadeMoedasDeUmrealDoTroco += 1;
                    troco -= 1;
                }
                else if (troco >= 0.5)
                {
                    quantidadeMoedasDeCinquentaCentavosDoTroco += 1;
                    troco -= 0.5;
                }
                else if (troco >= 0.25)
                {
                    quantidadeMoedasDeVinteCincoCentavosDoTroco += 1;
                    troco -= 0.25;
                }
                else if (troco >= 0.10)
                {
                    quantidadeMoedasDeDezCentavosDoTroco += 1;
                    troco -= 0.10;
                }
                else if (troco >= 0.05)
                {
                    quantidadeMoedasDeCincoCentavosDoTroco += 1;
                    troco -= 0.05;
                }

                troco = Math.Round(troco, 2);
            }
        }

        private void HabilitarBotoesDeSelecaoDoProduto()
        {
            btnCappuccino.Enabled = totalInserido >= 4;
            btnMocha.Enabled = totalInserido >= 3.5;
            btnCafeComLeite.Enabled = totalInserido >= 3;
        }

        private void HabilitarBotaoCancelar()
        {
            btnCancelar.Enabled = totalInserido > 0;
        }

        private void DesabilitarBotoes()
        {
            btnComprar.Enabled = false;
            btnCancelar.Enabled = false;
            btnCappuccino.Enabled = false;
            btnMocha.Enabled = false;
            btnCafeComLeite.Enabled = false;
        }

        private void FinalizaAOperacao(string mensagem)
        {
            EnviarTroco();
            MessageBox.Show(mensagem);
            ReiniciarValores();
        }

        private void ReiniciarValores()
        {
            totalInserido = 0;
            totalProdutoSelecionado = 0;
            totalTroco = 0;

            quantidadeMoedasDeUmrealDoTroco = 0;
            quantidadeMoedasDeCinquentaCentavosDoTroco = 0;
            quantidadeMoedasDeVinteCincoCentavosDoTroco = 0;
            quantidadeMoedasDeDezCentavosDoTroco = 0;
            quantidadeMoedasDeCincoCentavosDoTroco = 0;


            AtualizarLabelDeTotal();
            AtualizarLabelDeTroco();
            AtualizarLabelDeValorInserido();
            DesabilitarBotoes();
        }

        private void EnviarTroco()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendingMachine));

            for (int i = 0; i < quantidadeMoedasDeUmrealDoTroco; i++)
            {
                flpTroco.Controls.Add(new PictureBox()
                {
                    Image = (System.Drawing.Image)(resources.GetObject("pbUmReal.Image")),
                    Size = new Size(43, 39),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
            }
            for (int i = 0; i < quantidadeMoedasDeCinquentaCentavosDoTroco; i++)
            {
                flpTroco.Controls.Add(new PictureBox()
                {
                    Image = (System.Drawing.Image)(resources.GetObject("pbCinquentaCentavos.Image")),
                    Size = new Size(43, 39),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
            }
            for (int i = 0; i < quantidadeMoedasDeVinteCincoCentavosDoTroco; i++)
            {
                flpTroco.Controls.Add(new PictureBox()
                {
                    Image = (System.Drawing.Image)(resources.GetObject("pbVinteCincoCentavos.Image")),
                    Size = new Size(43, 39),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
            }
            for (int i = 0; i < quantidadeMoedasDeDezCentavosDoTroco; i++)
            {
                flpTroco.Controls.Add(new PictureBox()
                {
                    Image = (System.Drawing.Image)(resources.GetObject("pbDezCentavos.Image")),
                    Size = new Size(43, 39),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
            }
            for (int i = 0; i < quantidadeMoedasDeCincoCentavosDoTroco; i++)
            {
                flpTroco.Controls.Add(new PictureBox()
                {
                    Image = (System.Drawing.Image)(resources.GetObject("pbCincoCentavos.Image")),
                    Size = new Size(43, 39),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
            }
        }
    }
}
