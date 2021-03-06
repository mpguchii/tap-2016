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
            btnGerar.Enabled = false;
            grdOrd.Enabled = false;

        }



        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            Int32.TryParse(txtNum.Text, out i);

            if (txtNum.Text != "")
            {
                if (i > 0)
                {
                    btnGerar.Enabled = true;
                    grdOrd.Enabled = true;
                }
                else
                {
                    btnGerar.Enabled = false;
                    grdOrd.Enabled = false;
                    lstNumeros.Items.Clear();
                    lstResultado.Items.Clear();

                }
            }
            else
            {
                btnGerar.Enabled = false;
                grdOrd.Enabled = false;
                lstNumeros.Items.Clear();
                lstResultado.Items.Clear();
            }

            this.Text = "Ordenação";
        }

        static string GetMetodo(ordenacao ord)
        {
            var metodo = string.Empty;
            switch (ord)
            {
                case ordenacao.Insertion:
                    metodo = "Insertion Sort";
                    break;
                case ordenacao.Selection:
                    metodo = "Selection Sort";
                    break;
                case ordenacao.Quick:
                    metodo = "Quick Sort";
                    break;
                case ordenacao.Heap:
                    metodo = "Heap Sort";
                    break;
                case ordenacao.Bucket:
                    metodo = "Bucket Sort";
                    break;
                case ordenacao.Radix:
                    metodo = "Radix Sort";
                    break;
                case ordenacao.Merge:
                    metodo = "Merge Sort";
                    break;
                case ordenacao.Cocktail:
                    metodo = "Cocktail Sort";
                    break;
                case ordenacao.Comb:
                    metodo = "Comb Sort";
                    break;
                case ordenacao.Shell:
                    metodo = "Shell Sort";
                    break;
            }

            return metodo;
        }


        #region Ordenar
        private void Ordenar(ordenacao ord)
        {
            /*
             *Método Ordenar: Método Base do Processo.
             *Nele é feito todo o processo de ordenação de cada um dos métodos. 
             */

            //"zerar" o label e limpar o listbox do resultado 

            if (lstNumeros.Items.Count > 0)
            {

                lblTempo.Text = "00:00:00.000000";
                lstResultado.Items.Clear();

                //definição do timer para contagem do tempo de ordenação
                var timer = new Stopwatch();

                var metodo = string.Empty;

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
                            Resultado = Ordenacao.InsertionSort(array);

                            //parar o timer
                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Insertion);

                            break;
                        //Para todos os métodos abaixo o processo é o mesmo do descrito acima
                        case ordenacao.Selection:

                            timer.Start();

                            Resultado = Ordenacao.selectionSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Selection);

                            break;

                        case ordenacao.Quick:

                            timer.Start();

                            Resultado = Ordenacao.quickSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Quick);

                            break;

                        case ordenacao.Heap:
                            timer.Start();

                            Resultado = Ordenacao.heapSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Heap);

                            break;

                        case ordenacao.Bucket:

                            timer.Start();

                            Resultado = Ordenacao.BucketSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Bucket);

                            break;

                        case ordenacao.Radix:

                            timer.Start();

                            Resultado = Ordenacao.RadixSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Radix);

                            break;

                        case ordenacao.Merge:

                            timer.Start();

                            Resultado = Ordenacao.MergeSortIni(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Merge);

                            break;

                        case ordenacao.Cocktail:

                            timer.Start();

                            Resultado = Ordenacao.cocktailSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Cocktail);

                            break;

                        case ordenacao.Comb:

                            timer.Start();

                            Resultado = Ordenacao.combSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Comb);

                            break;

                        case ordenacao.Shell:
                            timer.Start();

                            Resultado = Ordenacao.shellSort(array);

                            timer.Stop();

                            metodo = GetMetodo(ordenacao.Shell);

                            break;
                    }

                    // for para varrer o array com os itens ordenados e jogar dentyro do listbox dos itens ordenados
                    // obs: esse processo demora alguns segundos acima do 20000 números gerados
                    lstResultado.BeginUpdate();//adicionado para deixar mais rápido o preenchimento do listbox
                    for (int i = 0; i < Resultado.Length; i++)
                    {
                        lstResultado.Items.Add(Resultado[i]);
                    }
                    lstResultado.EndUpdate();//adicionado para deixar mais rápido o preenchimento do listbox
                    //tempo gasto vai no label de controle de tempo
                    lblTempo.Text = timer.Elapsed.ToString();

                    this.Text = "Ordenação ::: Método " + metodo + " executado em " + timer.Elapsed.ToString() + " segundos";

                }
                else
                {
                    MessageBox.Show("Por Favor, Insira um número válido no campo Quantidade de Números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por Favor Clique no botão Gerar para gerar números antes de selecionar um método de ordenação!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion


        private void Gerar()
        {
            /*
             * Código Abaixo é somente para gerar números aleatórios 
             * e jogar dentro do listbox.
             */

            lstResultado.Items.Clear();
            lstNumeros.Items.Clear();
            this.Text = "Ordenação";
            Random randNum = new Random();
            int i = 0;

            Int32.TryParse(txtNum.Text, out i);


            Random rnd = new Random();

            lstNumeros.BeginUpdate();//adicionado para deixar mai rápido o preenchimento do listbox
            for (int count = 0; count < i; count++)
                lstNumeros.Items.Add(rnd.Next(i + 1).ToString());
            lstNumeros.EndUpdate();//adicionado para deixar mai rápido o preenchimento do listbox
        }

        private void Testar()
        {

            List<Tuple<string, string>> lista = new List<Tuple<string, string>>();
            
            int i = 0;
            var timer = new Stopwatch();
            string metodo = string.Empty;
            int[] Resultado = new int[0];

            int[] array = new int[lstNumeros.Items.Count];

            for (i = 0; i < lstNumeros.Items.Count; i++)
            {
                array[i] = Int32.Parse(lstNumeros.Items[i].ToString());
            }

            i = 0;

            for (i = 1; i < 11; i++)
            {
                ordenacao ord = (ordenacao)i;
                timer.Reset();
                switch (ord)
                {
                    case ordenacao.Insertion:
                        timer.Start();
                        Resultado = Ordenacao.InsertionSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Selection:
                        timer.Start();
                        Resultado = Ordenacao.selectionSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Quick:
                        timer.Reset();
                        timer.Start();
                        Resultado = Ordenacao.quickSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Heap:
                        timer.Start();
                        Resultado = Ordenacao.heapSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Bucket:
                        timer.Start();
                        Resultado = Ordenacao.BucketSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Radix:
                        timer.Start();
                        Resultado = Ordenacao.RadixSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Merge:
                        timer.Start();
                        Resultado = Ordenacao.MergeSortIni(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Cocktail:
                        timer.Start();
                        Resultado = Ordenacao.cocktailSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Comb:
                        timer.Start();
                        Resultado = Ordenacao.combSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                    case ordenacao.Shell:
                        timer.Start();
                        Resultado = Ordenacao.shellSort(array);
                        timer.Stop();
                        metodo = GetMetodo(ord);
                        break;
                }

                lista.Add(new Tuple<string, string>(metodo, timer.Elapsed.ToString()));

            }
            frmResultado resultado = new frmResultado();
            resultado.Carregar(lista);
            resultado.Show();

        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            Gerar();
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

                if (e.KeyChar == 13) Gerar(); //se a tecla enter for pressionada chama o método Gerar.
            }
        }

        private void btnTestarTodos_Click(object sender, EventArgs e)
        {
            Testar();
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
            Ordenar(ordenacao.Merge);
        }
        #endregion

        #region Cocktail
        private void btnCocktailsSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Cocktail);
        }
        #endregion

        #region Comb
        private void btnCombSort_Click(object sender, EventArgs e)
        {
            Ordenar(ordenacao.Comb);
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

