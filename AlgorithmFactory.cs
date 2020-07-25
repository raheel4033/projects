using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DS
{
    abstract class AlgorithmFactory : SortingAlgorithms
    {
        public abstract int[] Arr { get; set; }
        public abstract void SelectionSort();

        public abstract void BubbleSort();

        public abstract void HeapSort(int[] input);

        public abstract void MaxHeapify(int[] input, int heapSize, int index);

        public abstract void MergeArray(int[] array, int start, int mid, int end);

        public abstract void MergeSort(int[] arr, int start, int end);

        public abstract int Partition(int[] input, int left, int right);

        public abstract void QuickSort(int[] input, int left, int right);

        public abstract int[] CountingSort(int[] array);
        

    }
}
