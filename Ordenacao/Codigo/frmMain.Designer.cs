﻿namespace Ordenacao
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.grdOrd = new System.Windows.Forms.GroupBox();
            this.btnCombSort = new System.Windows.Forms.Button();
            this.btnCocktailsSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.btnBucketSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestarTodos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grdOrd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(86, 21);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(76, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade \r\nde Números";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(168, 19);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNumeros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar Números";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(9, 57);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(246, 264);
            this.lstNumeros.TabIndex = 3;
            // 
            // grdOrd
            // 
            this.grdOrd.Controls.Add(this.btnTestarTodos);
            this.grdOrd.Controls.Add(this.btnCombSort);
            this.grdOrd.Controls.Add(this.btnCocktailsSort);
            this.grdOrd.Controls.Add(this.btnMergeSort);
            this.grdOrd.Controls.Add(this.btnRadixSort);
            this.grdOrd.Controls.Add(this.btnBucketSort);
            this.grdOrd.Controls.Add(this.btnInsertionSort);
            this.grdOrd.Controls.Add(this.btnHeapSort);
            this.grdOrd.Controls.Add(this.btnSelectionSort);
            this.grdOrd.Controls.Add(this.btnShellSort);
            this.grdOrd.Controls.Add(this.btnQuickSort);
            this.grdOrd.Location = new System.Drawing.Point(283, 6);
            this.grdOrd.Name = "grdOrd";
            this.grdOrd.Size = new System.Drawing.Size(139, 330);
            this.grdOrd.TabIndex = 4;
            this.grdOrd.TabStop = false;
            this.grdOrd.Text = "Método De Ordenação";
            // 
            // btnCombSort
            // 
            this.btnCombSort.Location = new System.Drawing.Point(21, 273);
            this.btnCombSort.Name = "btnCombSort";
            this.btnCombSort.Size = new System.Drawing.Size(93, 23);
            this.btnCombSort.TabIndex = 10;
            this.btnCombSort.Text = "Comb Sort";
            this.btnCombSort.UseVisualStyleBackColor = true;
            this.btnCombSort.Click += new System.EventHandler(this.btnCombSort_Click);
            // 
            // btnCocktailsSort
            // 
            this.btnCocktailsSort.Location = new System.Drawing.Point(21, 244);
            this.btnCocktailsSort.Name = "btnCocktailsSort";
            this.btnCocktailsSort.Size = new System.Drawing.Size(93, 23);
            this.btnCocktailsSort.TabIndex = 9;
            this.btnCocktailsSort.Text = "Cocktails Sort";
            this.btnCocktailsSort.UseVisualStyleBackColor = true;
            this.btnCocktailsSort.Click += new System.EventHandler(this.btnCocktailsSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(21, 216);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(93, 23);
            this.btnMergeSort.TabIndex = 8;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.Location = new System.Drawing.Point(21, 187);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(93, 23);
            this.btnRadixSort.TabIndex = 7;
            this.btnRadixSort.Text = "Radix Sort";
            this.btnRadixSort.UseVisualStyleBackColor = true;
            this.btnRadixSort.Click += new System.EventHandler(this.btnRadixSort_Click);
            // 
            // btnBucketSort
            // 
            this.btnBucketSort.Location = new System.Drawing.Point(21, 158);
            this.btnBucketSort.Name = "btnBucketSort";
            this.btnBucketSort.Size = new System.Drawing.Size(93, 23);
            this.btnBucketSort.TabIndex = 6;
            this.btnBucketSort.Text = "Bucket Sort";
            this.btnBucketSort.UseVisualStyleBackColor = true;
            this.btnBucketSort.Click += new System.EventHandler(this.btnBucketSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(21, 42);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(93, 23);
            this.btnInsertionSort.TabIndex = 5;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(21, 129);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(93, 23);
            this.btnHeapSort.TabIndex = 5;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapShort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(21, 71);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(93, 23);
            this.btnSelectionSort.TabIndex = 5;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(21, 301);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(93, 23);
            this.btnShellSort.TabIndex = 5;
            this.btnShellSort.Text = "Shell Sort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(21, 100);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(93, 23);
            this.btnQuickSort.TabIndex = 5;
            this.btnQuickSort.Text = "QuickSort ";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTempo);
            this.groupBox2.Controls.Add(this.lstResultado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(428, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 329);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Red;
            this.lblTempo.Location = new System.Drawing.Point(93, 24);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(145, 24);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "00:00:00.000000";
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(6, 57);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(245, 264);
            this.lstResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo Gasto";
            // 
            // btnTestarTodos
            // 
            this.btnTestarTodos.Location = new System.Drawing.Point(21, 15);
            this.btnTestarTodos.Name = "btnTestarTodos";
            this.btnTestarTodos.Size = new System.Drawing.Size(93, 23);
            this.btnTestarTodos.TabIndex = 11;
            this.btnTestarTodos.Text = "Testar Todos";
            this.btnTestarTodos.UseVisualStyleBackColor = true;
            this.btnTestarTodos.Click += new System.EventHandler(this.btnTestarTodos_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdOrd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grdOrd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.GroupBox grdOrd;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnBucketSort;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnCocktailsSort;
        private System.Windows.Forms.Button btnCombSort;
        private System.Windows.Forms.Button btnTestarTodos;
    }
}

