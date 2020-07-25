using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DS
{
    interface SortingAlgorithms:selectionSort,bubbleSort,heapSort,mergeSort,countingSort
    {
        new void SelectionSort();
        new void BubbleSort();
        new void HeapSort(int[] input);

        new void MaxHeapify(int[] input, int heapSize, int index);
        new int[] CountingSort(int[] array);

        int Partition(int[] input, int left, int right);

        void QuickSort(int[] input, int left, int right);
        new void MergeArray(int[] array, int start, int mid, int end);

        new void MergeSort(int[] arr, int start, int end);

    }
}
