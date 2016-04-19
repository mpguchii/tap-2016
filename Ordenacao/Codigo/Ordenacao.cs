using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class Ordenacao
    {

        #region Insertion Sort

        /*
         * Insertion Sort
         * Algoritimo Adaptado de http://www.softwareandfinance.com/CSharp/Insertion_Sort.html
         */
        public static int[] InsertionSort(int[] vetor)
        {
            int i, j, atual;
            //for para varrer todo o vetor
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i]; //guarda a posição do vetor atual
                j = i;
                
                //while que enquanto a varivel j for maior que 0 e o número
                //na posição do vetor for maior que o numero atual
                //vai ordenando os elementos do vetor mais a esquerda 
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];//passa o número anterior para a posição atual do vetor
                    j = j - 1;// e diminui uma posição de j
                }

                vetor[j] = atual; //passa o número guardado para uma posição antes no vetor
            }

            return vetor;
        }
        #endregion

        #region Shell Sort

        /*
         * Shell Sort
         * Algoritimo Adaptado de http://www.codeproject.com/Articles/80546/Comparison-Sorting-Algorithms-in-C-Explained
         */
        public static int[] shellSort(int[] vetor)
        {
            int j, temp = 0;
            int metade = (vetor.Length) / 2;
            while (metade > 0) //até que a metade seja maior que 0
            {
                for (int index = 0; index < vetor.Length; index++) // for que enquanto o index for menor que o tamanho do vetor
                {
                    j = index;
                    temp = vetor[index];
                    while ((j >= metade) && vetor[j - metade] > temp) //enquanto j for maior ou igual a metade e o vetor na posição
                    {                                                 //[j-metade]  for maior que a variavel temp
                        vetor[j] = vetor[j - metade]; //vetor na posição[j] vai receber vetor na posição[j-metadae]
                        j = j - metade;
                    }
                    vetor[j] = temp;
                }
                if (metade / 2 != 0) //se a diferença da metade / 2 for = 0 
                    metade = metade / 2; //a metade e novamente dividida por 2
                else if (metade == 1)
                    metade = 0; 
                else
                    metade = 1;
            }

            return vetor;
        }

        #endregion

        #region Selection Sort
        /*
         * Selection Sort
         * Algoritimo Adaptado de http://cforbeginners.com/CSharp/SelectionSort.html
         */
        public static int[] selectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++) //for que e executado até i ser menor que o tamanho do vetor -1
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++) //for que é executado até j seja menor que o tamanho do vetor
                    if (vetor[j] < vetor[min]) //se o vetor na posicao[j] for< vetor na posicao[min]
                        min = j; //menor valor no vetor

                if (min != i) //se o valor menor do vetor for diferente de 1
                {
                    aux = vetor[min];    // faz a troca de posição entre os menores valor
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }

#endregion

        #region Heap Sort
        /*
            Heap Soprt 
            Algoritimo Adapatdo de http://csharpbrasil.com.br/algoritmos-de-ordenacao-em-csharp/
         */
        public static int[] heapSort(int[] vetor)
        {
            buildMaxHeap(vetor); /*Cria o Heap*/
            int n = vetor.Length;

            for (int i = vetor.Length - 1; i > 0; i--)
            {                                         
                troca(vetor, i, 0);          /*Coloca o maior elemento no final do vetor*/
                maxHeapify(vetor, 0, --n);   /*Refaz o Heap, desconsiderando o elemento que foi p/ o final até que o vetor esteja ordenado*/
            }

            return vetor;
        }

        private static void buildMaxHeap(int[] v)
        {
            for (int i = v.Length / 2 - 1; i >= 0; i--) /*Para cada nó interno(não-folha),*/
            {
                maxHeapify(v, i, v.Length);             /* chama maxHeapify, seguindo o sentido folha-raiz*/
            }
        }

        private static void maxHeapify(int[] v, int pos, int n)
        {
            int max = 2 * pos + 1, right = max + 1; /*
               Uma árvore heap é representada como um array. Para você obter os filhos de um elemento, 
               vc precisa multiplicar sua posição por 2. */
            if (max < n)
            {
                if (right < n && v[max] < v[right]) /*aqui ele obtém as posições dos filhos (max e right) de pos.*/
                {
                    max = right; 
                }
                if (v[max] > v[pos]) /*aqui ele verifica qual dos dois filhos possuem o maior valor e faz a troca*/
                {
                    troca(v, max, pos);
                    maxHeapify(v, max, n);
                }
            }
        }

        private static void troca(int[] v, int j, int aposJ) /*função simples para realizar a troca entre os nós*/
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
        }

        #endregion

        #region Quick Sort

        /*
            Heap Soprt 
            Algoritimo Adapatdo de http://www.softwareandfinance.com/CSharp/QuickSort_Recursive.html
         */

        public static int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            quickSort(vetor, inicio, fim); /*chama a função quickSort */

            return vetor;
        }

        private static void quickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }

        #endregion

        #region Bucket Sort(Bin Sort)
        public static int[] BucketSort(int[] data)
        {
            int minValue = data[0];
            int maxValue = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                if (data[i] < minValue)
                    minValue = data[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < data.Length; i++)
            {
                bucket[data[i] - minValue].Add(data[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        data[k] = bucket[i][j];
                        k++;
                    }
                }
            }

            return data;
        }
        #endregion

        #region Radix Sort

        public static int[] RadixSort(int[] data)
        {
            int i, j;
            int[] temp = new int[data.Length];

            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;

                for (i = 0; i < data.Length; ++i)
                {
                    bool move = (data[i] << shift) >= 0;

                    if (shift == 0 ? !move : move)
                        data[i - j] = data[i];
                    else
                        temp[j++] = data[i];
                }

                Array.Copy(temp, 0, data, data.Length - j, j);
            }

            return temp;
        }

        #endregion

        #region Merge Sort
        public static int[] MergeSortIni(int[] unsortedArray)
        {

            MergeSort(ref unsortedArray, 0, unsortedArray.Length - 1);

            return unsortedArray;
        }

        private static void MergeSort(ref int[] unsortedArray, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                //Sort left (will call Merge to produce a fully sorted left array)
                MergeSort(ref unsortedArray, leftIndex, middleIndex);
                //Sort right (will call Merge to produce a fully sorted right array)
                MergeSort(ref unsortedArray, middleIndex + 1, rightIndex);
                //Merge the sorted left & right to finish off.
                Merge(ref unsortedArray, leftIndex, middleIndex, rightIndex);
            }
        }

        private static void Merge(ref int[] unsortedArray, int leftIndex, int middleIndex, int rightIndex)
        {
            int lengthLeft = middleIndex - leftIndex + 1;
            int lengthRight = rightIndex - middleIndex;
            int[] leftArray = new int[lengthLeft + 1];
            int[] rightArray = new int[lengthRight + 1];
            for (int i = 0; i < lengthLeft; i++)
            {
                leftArray[i] = unsortedArray[leftIndex + i];
            }
            for (int j = 0; j < lengthRight; j++)
            {
                rightArray[j] = unsortedArray[middleIndex + j + 1];
            }
            leftArray[lengthLeft] = Int32.MaxValue;
            rightArray[lengthRight] = Int32.MaxValue;
            int iIndex = 0;
            int jIndex = 0;
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    unsortedArray[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    unsortedArray[k] = rightArray[jIndex];
                    jIndex++;
                }
            }
        }
        #endregion

        #region Cocktails Sort

        public static int[] cocktailSort(int[] vetor)
        {
            int tamanho, inicio, fim, swap, aux;
            tamanho = vetor.Length;
            inicio = 0;
            fim = tamanho - 1;
            swap = 0;
            while (swap == 0 && inicio < fim)
            {
                swap = 1;
                for (int i = inicio; i < fim; i = i + 1)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        swap = 0;
                    }
                }

                fim = fim - 1;

                for (int i = fim; i > inicio; i = i - 1)
                {
                    if (vetor[i] < vetor[i - 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i - 1];
                        vetor[i - 1] = aux;
                        swap = 0;
                    }
                }

                inicio = inicio + 1;
            }

            return vetor;
        }

        #endregion

        #region Comb Sort
        public static int[] combSort(int[] vetor)
        {
            int gap = vetor.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / 1.247330950103979);
                }

                int i = 0;
                swapped = false;
                while (i + gap < vetor.Length)
                {
                    if (vetor[i].CompareTo(vetor[i + gap]) > 0)
                    {
                        int t = vetor[i];
                        vetor[i] = vetor[i + gap];
                        vetor[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }

            return vetor;
        }
    }
        #endregion
}
