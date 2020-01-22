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
   public partial class frmApuracao : Form
   {
      public frmApuracao()
      {
         InitializeComponent();
      }
      public frmApuracao(int candidato13,int candidato17,int candidato18,int candidato51, int branco)
      {
         InitializeComponent();
         lblCand1.Text = candidato13.ToString();
         lblCand2.Text = candidato17.ToString();
         lblCand3.Text = candidato18.ToString();
         lblCand4.Text = candidato51.ToString();
         lblBranco.Text = branco.ToString();
      }
      
      private void btnFechar_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
