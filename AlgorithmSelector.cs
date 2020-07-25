using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DS
{
    class AlgorithmSelector : AlgorithmFactory
    {
        static int instanceCounter = 0;
        private static AlgorithmSelector uniqueinstance=null;
        private static readonly object lockobject = new object();
        private AlgorithmSelector()
        {
            instanceCounter++;
        }
        public static AlgorithmSelector SingleInstance
        {
            get
            {
                lock (lockobject)
                {
                    if (uniqueinstance==null)
                    {
                        uniqueinstance = new AlgorithmSelector();
                    }
                }
                return uniqueinstance;
            }
        }
        public override int[] Arr { get; set; }
        public override void SelectionSort()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                int mini = Arr[i];
                int pos = i;

                for (int j = i; j < Arr.Length; j++)
                {
                    if (Arr[j] < mini)
                    {
                        mini = Arr[j];
                        pos = j;
                    }
                }
                //swamping elements........
                int temp = Arr[i];
                Arr[i] = Arr[pos];
                Arr[pos] = temp;


            }
        }
        public override void BubbleSort()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp;
                        temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }


        }
        public override void HeapSort(int[] input)
        {
            //Build-Max-Heap
            int heapSize = input.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            for (int i = input.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }
        public override void MaxHeapify(int[] input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;     //2i
            int right = (index + 1) * 2;        //2i+1
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }
        public override void MergeArray(int[] array, int start, int mid, int end)
        {
            /* Create a temporary array for stroing merged array (Length of temp array will be 
             * sum of size of both array to be merged)*/
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;
            // Now traverse both array simultaniously and store the smallest element of both to temp array
            while (i <= mid && j <= end)
            {
                if (array[i] < array[j])
                {
                    temp[k] = array[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = array[j];
                    k++;
                    j++;
                }
            }
            // If there is any element remain in first array then add it to temp array
            while (i <= mid)
            {
                temp[k] = array[i];
                k++;
                i++;
            }
            // If any element remain in second array then add it to temp array
            while (j <= end)
            {
                temp[k] = array[j];
                k++;
                j++;
            }
            // Now temp has merged sorted element of both array

            // Traverse temp array and store element of temp array to original array
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                array[i] = temp[k];
                i++;
                k++;
            }
        }
        // Recursive Merge Procedure
        public override void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                MergeArray(arr, start, mid, end);
            }
        }
        public override int Partition(int[] input, int left, int right)
        {
            int pivot = input[right];

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    var temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }
        public override void QuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }
        public override int[] CountingSort(int[] array)
        {
            // array to be sorted in, this array is necessary
            // when we sort object datatypes, if we don't, 
            // we can sort directly into the input array     
            int[] aux = new int[array.Length];

            // find the smallest and the largest value
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                else if (array[i] > max) max = array[i];
            }

            // init array of frequencies
            int[] counts = new int[max - min + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - min]++;
            }

            // recalculate the array - create the array of occurences
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array right to the left
            // 1) look up in the array of occurences the last occurence of the given value
            // 2) place it into the sorted array
            // 3) decrement the index of the last occurence of the given value
            // 4) continue with the previous value of the input array (goto: 1), terminate if all values were already sorted
            for (int i = array.Length - 1; i >= 0; i--)
            {
                aux[counts[array[i] - min]--] = array[i];
            }

            return aux;
        }
    }
}