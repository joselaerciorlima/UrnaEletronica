using System;
using System.Drawing;
using System.Windows.Forms;

namespace UrnaEletronica
{
   public partial class frmUrna : Form
   {
      bool candidatoValido = false;
      string numeroCanditado;
      int candidato13, candidato17, candidato18, candidato51, branco;
      string pastaImagens = "";

      public frmUrna()
      {
         InitializeComponent();
         pastaImagens = Application.StartupPath + @"\Imagens\";
         
      }

      private void btnUm_Click(object sender, EventArgs e)
      {
         Input("1");
      }

      private void btnDois_Click(object sender, EventArgs e)
      {
         Input("2");
      }

      private void btnTres_Click(object sender, EventArgs e)
      {
         Input("3");
      }

      private void btnQuatro_Click(object sender, EventArgs e)
      {
         Input("4");
      }

      private void btnCinco_Click(object sender, EventArgs e)
      {
         Input("5");
      }

      private void btnSeis_Click(object sender, EventArgs e)
      {
         Input("6");
      }

      private void btnSete_Click(object sender, EventArgs e)
      {
         Input("7");
      }

      private void btnOito_Click(object sender, EventArgs e)
      {
         Input("8");
      }

      private void btnNove_Click(object sender, EventArgs e)
      {
         Input("9");
      }

      private void btnZero_Click(object sender, EventArgs e)
      {
         Input("0");
      }

      private void btnCorrige_Click(object sender, EventArgs e)
      {
         Limpar();
         Ocultar();
      }

      private void btnBranco_Click(object sender, EventArgs e)
      {
         if (txtNumeroUm.Text == "" && txtNumeroDois.Text == "")
         {
            lblVoto.Visible = true;
            lblNome.Text = "VOTO EM BRANCO";
            lblNome.Visible = true;
            pnlAjuda.Visible = true;
            candidatoValido = true;
            numeroCanditado = "branco";
         }
         else
         {
            MessageBox.Show("Para votar em BRANCO o campo de voto deve estar vazio. Aperte CORRIGE para apagar o campo de voto.", "Atenção Eleitor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void btnConfirma_Click(object sender, EventArgs e)
      {
         if (candidatoValido)
         {
            switch (numeroCanditado)
            {
               case "13":
                  candidato13++;
                  break;
               case "17":
                  candidato17++;
                  break;
               case "18":
                  candidato18++;
                  break;
               case "51":
                  candidato51++;
                  break;
               case "branco":
                  branco++;
                  break;
            }
            Limpar();
            Ocultar();
         }
         else
         {
            MessageBox.Show("Para CONFIRMAR seu voto é necessário escolher os quatro números válidos ou votar em BRANCO.", "Atenção Eleitor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void Input(string valor)
      {
         if (txtNumeroUm.Text == "")
         {
            txtNumeroUm.Text = valor;
         }
         else if (txtNumeroDois.Text == "")
         {
            txtNumeroDois.Text = valor;
            Validar();
         }
         
      }

      private void Validar()
      {

         numeroCanditado = txtNumeroUm.Text + txtNumeroDois.Text;

         switch (numeroCanditado)
         {
            case "13":
               lblNome.Text = "Fernando Haddad";
               lblPartido.Text = "PT";
               exibirOcultos();
               candidatoValido = true;
               pcbCandidato.BackgroundImage = Image.FromFile(pastaImagens + "Haddad.jpg");
               break;
            case "17":
               lblNome.Text = "Jair Bolsonaro";
               lblPartido.Text = "PSL";
               exibirOcultos();
               candidatoValido = true;
               pcbCandidato.BackgroundImage = Image.FromFile(pastaImagens + "Bolsonaro.jpg");
               break;
            case "18":
               lblNome.Text = "Marina Silva";
               lblPartido.Text = "REDE";
               exibirOcultos();
               candidatoValido = true;
               pcbCandidato.BackgroundImage = Image.FromFile(pastaImagens + "Marina.jpg");
               break;
            case "51":
               lblNome.Text = "Cabo Daciolo";
               lblPartido.Text = "PATRIOTA";
               exibirOcultos();
               candidatoValido = true;
               pcbCandidato.BackgroundImage = Image.FromFile(pastaImagens + "Daciolo.jpg");
               break;
            default:
               lblNome.Text = "CANDIDATO INVÁLIDO";
               lblNome.Visible = true;
               candidatoValido = false;
               break;
         }

      }

      void Limpar()
      {
         txtNumeroUm.Text = "";
         txtNumeroDois.Text = "";
         
      }

      private void btnFinalizar_Click(object sender, EventArgs e)
      {
         var resultado = new frmApuracao(candidato13, candidato17, candidato18, candidato51, branco);
         resultado.ShowDialog();
      }

      void exibirOcultos()
      {
         lblVoto.Visible = true;
         pnlAjuda.Visible = true;
         pnlInfo.Visible = true;
         lblNome.Visible = true;
         lblPartido.Visible = true;
         pcbCandidato.Visible = true;
      }

      void Ocultar()
      {
         lblVoto.Visible = false;
         pnlAjuda.Visible = false;
         pnlInfo.Visible = false;
         lblNome.Visible = false;
         lblNome.Text = "";
         lblPartido.Visible = false;
         lblPartido.Text = "";
         pcbCandidato.Visible = false;
      }

     
   }
}
