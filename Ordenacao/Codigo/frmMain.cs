using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ordenacao
{

    public partial class frmMain : Form
    {

        #region Enumerador
        enum ordenacao
        {
            Insertion = 1,
            Selection = 2,
            Quick = 3,
            Heap = 4,
            Bucket = 5,
            Radix = 6,
            Merge = 7,
            Cocktail = 8,
            Comb = 9,
            Shell = 10
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }



        #region Ordenar
        private void Ordenar(ordenacao ord)
        {
            lblTempo.Text = "00:00:00.000000";
            lstResultado.Items.Clear();

            var timer = new Stopwatch();


            int[] array = new int[lstNumeros.Items.Count];

            int[] Resultado = new int[0];

            for (int i = 0; i < lstNumeros.Items.Count; i++)
            {
                array[i] = Int32.Parse(lstNumeros.Items[i].ToString());
            }

            if (txtNum.Text != "")
            {

                switch (ord)
                {
                    case ordenacao.Insertion:

                        timer.Start();

                        Resultado  = Ordenacao.InsertionSort(array);

                        timer.Stop();

                        break;

                    case ordenacao.Selection:

                        timer.Start();

                        Resultado = Ordenacao.selectionSort(array);

                        timer.Stop();

                        break;

                    case ordenacao.Quick:

                        timer.Start();

                        Resultado = Ordenacao.quickSort(array);

                        timer.Stop();
                        break;

                    case ordenacao.Heap:
                        timer.Start();

                        Resultado = Ordenacao.heapSort(array);

                        timer.Stop();
                        break;

                    case ordenacao.Bucket:

                        timer.Start();

                        Resultado = Ordenacao.BucketSort(array);

                        timer.Stop();
                        break;

                    case ordenacao.Radix:

                        timer.Start();

                        Resultado = Ordenacao.RadixSort(array);

                        timer.Stop();

                        break;

                    case ordenacao.Merge:

                       timer.Start();

                        Resultado = Ordenacao.MergeSortIni(array);

                        timer.Stop();

                        break;

                    case ordenacao.Cocktail:

                        timer.Start();

                        Resultado = Ordenacao.cocktailSort(array);

                        timer.Stop();

                        break;

                    case ordenacao.Comb:

                        timer.Start();

                        Resultado = Ordenacao.combSort(array);

                        timer.Stop();

                        break;

                    case ordenacao.Shell:
                        timer.Start();

                        Resultado = Ordenacao.shellSort(array);

                        timer.Stop();
                        break;
                }

                for (int i = 0; i < Resultado.Length; i++)
                {
                    lstResultado.Items.Add(Resultado[i]);
                }
                
                lblTempo.Text = timer.Elapsed.ToString();

            }
            else
            {
                MessageBox.Show("Por Favor, Insira um número válido no campo Quantidade de Números!");
            }
        }
        #endregion


        #region Insertion
        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Insertion);
        }
        #endregion

        #region Selection
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Selection);

        }
        #endregion

        #region Quick
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Quick);
        }
        #endregion

        #region Heap
        private void btnHeapShort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Heap);

        }
        #endregion

        #region Bucket
        private void btnBucketSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Bucket);
        }
        #endregion

        #region Radix
        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Radix);
        }
        #endregion

        #region Merge
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            lblTempo.Text = "00:00:00.000000";
            var timer = new Stopwatch();

            int[] array = new int[lstNumeros.Items.Count];

            for (int i = 0; i < lstNumeros.Items.Count; i++)
            {
                array[i] = Int32.Parse(lstNumeros.Items[i].ToString());
            }


            timer.Start();

            int[] resultado = Ordenacao.MergeSortIni(array);

            for (int i = 0; i < resultado.Length; i++)
            {
                lstResultado.Items.Add(resultado[i]);
            }

            timer.Stop();
            lblTempo.Text = timer.Elapsed.ToString();
        }
        #endregion

        #region Cocktail
        private void btnCocktailsSort_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            lblTempo.Text = "00:00:00.000000";
            var timer = new Stopwatch();

            int[] array = new int[lstNumeros.Items.Count];

            for (int i = 0; i < lstNumeros.Items.Count; i++)
            {
                array[i] = Int32.Parse(lstNumeros.Items[i].ToString());
            }


            timer.Start();

            int[] resultado = Ordenacao.MergeSortIni(array);

            for (int i = 0; i < resultado.Length; i++)
            {
                lstResultado.Items.Add(resultado[i]);
            }

            timer.Stop();
            lblTempo.Text = timer.Elapsed.ToString();
        }
        #endregion

        #region Comb
        private void btnCombSort_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            lblTempo.Text = "00:00:00.000000";
            var timer = new Stopwatch();

            int[] array = new int[lstNumeros.Items.Count];

            for (int i = 0; i < lstNumeros.Items.Count; i++)
            {
                array[i] = Int32.Parse(lstNumeros.Items[i].ToString());
            }


            timer.Start();

            int[] resultado = Ordenacao.combSort(array);

            for (int i = 0; i < resultado.Length; i++)
            {
                lstResultado.Items.Add(resultado[i]);
            }

            timer.Stop();
            lblTempo.Text = timer.Elapsed.ToString();
        }
        #endregion

        #region Shell
        private void btnShellSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Shell);
        }
        #endregion

        private void btnGerar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            lstNumeros.Items.Clear();
            Random randNum = new Random();
            int i = 0;
            Int32.TryParse(txtNum.Text, out i);

            Random rnd = new Random();

            for (int count = 0; count < i; count++)
                lstNumeros.Items.Add(rnd.Next(i + 1).ToString());
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }



    }
}

