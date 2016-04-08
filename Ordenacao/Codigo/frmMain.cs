﻿using System;
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
        /*
         *Enumerador:
         *Enumerador utulizados para facililitar o processo de ordenação,
         *além de deixar o código mais bonito e orientado.
         */
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


        /*
         *Método Ordenar: Método Base do Processo.
         *Nele é feito todo o processo de ordenação de cada um dos métodos. 
         */

        #region Ordenar
        private void Ordenar(ordenacao ord)
        {
            //"zerar" o label e limpar o listbox do resultado 
            lblTempo.Text = "00:00:00.000000";
            lstResultado.Items.Clear();

            //definição do timer para contagem do tempo de ordenação
            var timer = new Stopwatch();

            //definicão do array com tamanho dos item do listbox dos números gerados
            int[] array = new int[lstNumeros.Items.Count];
            
            int[] Resultado = new int[0];

            //for para varrer o listbox dos números gerados e adicionar na array
            // obs: esse processo demora alguns segundos acima do 20000 números gerados
            for (int i = 0; i < lstNumeros.Items.Count; i++)
            {
                array[i] = Int32.Parse(lstNumeros.Items[i].ToString());
            }

            if (txtNum.Text != "")
            {
                //switch para verificar qual método de ordenação foi selecionado
                switch (ord)
                {
                    case ordenacao.Insertion:

                        //inicio do timer
                        timer.Start();

                        //array resultado receber os numeros já ordenados
                        //vindo dos método de ordenação presente na classe Ordenação.cs
                        Resultado  = Ordenacao.InsertionSort(array);
                        
                        //parar o timer
                        timer.Stop();

                        break;
                        //Para todos os métodos abaixo o processo é o mesmo do descrito acima
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

                // for para varrer o array com os itens ordenados e jogar dentyro do listbox dos itens ordenados
                // obs: esse processo demora alguns segundos acima do 20000 números gerados
                for (int i = 0; i < Resultado.Length; i++)
                {
                    lstResultado.Items.Add(Resultado[i]);
                }
                
                //tempo gasto vai no label de controle de tempo
                lblTempo.Text = timer.Elapsed.ToString();

            }
            else
            {
                MessageBox.Show("Por Favor, Insira um número válido no campo Quantidade de Números!");
            }
        }
        #endregion


        private void btnGerar_Click(object sender, EventArgs e)
        {
            /*
             * Código Abaixo é somente para gerar números aleatórios 
             * e jogar dentro do listbox.
             */

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

            /*
             *Código Abaixo somente feito para evitar  
             * de ser digitado uma letra por exemplo no textbox.
             */
            if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }


        /*
         * Métodos de Ordenação
         * A partir de aqui, para cada botão, é chamado seu respectivo método de ordenação no Método Ordenar.
         * Ex.: Ordenar(ordenacao.Insertion);
         * Ou seja dentro do click do botão Insertion é chamado o método Ordenar passando o método selecionado.
         */

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


    }
}

