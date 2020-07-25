using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DS
{
    interface heapSort
    {
        void HeapSort(int[] input);
       
        void MaxHeapify(int[] input, int heapSize, int index);
        
    }
}
