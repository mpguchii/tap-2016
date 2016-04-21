using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            
        }

        public void Carregar(List<Tuple<string, string>> lista)
        {
            gDados.Titles.Add("Resultado");

            gDados.Series.Clear();


            List<Tuple<string, string>> listaord = new List<Tuple<string, string>>();

            int i = 0;

            foreach (var lst in lista)
            {
              
                gDados.Series.Add(lst.Item1);

                var milsec = lst.Item2.Substring(6, 8);
                
                gDados.Series[i].Points.Add(Convert.ToInt32((Convert.ToDouble(milsec))));
                
                i++;
            }
            

        }
    }
}
