using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
   public partial class Form1 : Form
   {

      string[] Candidatos = { "1111-Candidato Numero Um-PSbl" };
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         
      }

      private void btnUm_Click(object sender, EventArgs e)
      {
         Input("1");
         
      }
      private void btnCorrige_Click(object sender, EventArgs e)
      {
         txtNumeroUm.Text = "";
         txtNumeroDois.Text = "";
         txtNumeroTres.Text = "";
         txtNumeroQuatro.Text = "";
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
         }
         else if (txtNumeroTres.Text == "")
         {
            txtNumeroTres.Text = valor;
         }
         else if (txtNumeroQuatro.Text == "")
         {
            txtNumeroQuatro.Text = valor;
            Validar();
         }
      }

      private void Validar()
      {

         string numeroCanditado = txtNumeroUm.Text + txtNumeroDois.Text + txtNumeroTres.Text + txtNumeroQuatro.Text;

         
         
         if (Candidatos.Contains(numeroCanditado))
         {

            MessageBox.Show("");
         }


      }

   }
}
