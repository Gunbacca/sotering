using System.Diagnostics;
 Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
List<int> tal = new List<int>();
Random random = new Random();

for(int i = 0; i < 100_00; i++){
    tal.Add(random.Next());
}
stopwatch.Stop();
stopwatch.Reset();
List<int> bubble = new List<int>(tal);
stopwatch.Start();

SelectionSort(bubble);

stopwatch.Stop();

Console.WriteLine($"Tiden för loopen att köra selecionsort: {stopwatch.Elapsed.TotalMilliseconds} ms");
List<int> merge = new List<int>(tal);
stopwatch.Restart();
MergeSort(tal);
stopwatch.Stop();    
Console.WriteLine($"Tiden för loopen att köra Mergesort: {stopwatch.Elapsed.TotalMilliseconds} ms");
List<int> bubble1 = new List<int>(tal);
stopwatch.Restart();
MergeSort(tal);
stopwatch.Stop();    
Console.WriteLine($"Tiden för loopen att köra bulllesort: {stopwatch.Elapsed.TotalMilliseconds} ms");
List<int> quick = new List<int>(tal);
stopwatch.Restart();
MergeSort(tal);
stopwatch.Stop();    
Console.WriteLine($"Tiden för loopen att köra quicksort: {stopwatch.Elapsed.TotalMilliseconds} ms");




void BubbleSort(List<int> bubble){
    for(int i=0; i<bubble.Count; i++){
        for(int j=0; j<bubble.Count-1-i; j++){
            if(bubble[j]>bubble[j+1]){
                int swap= bubble[j];
                bubble[j]=bubble[j+1];
                bubble[j+1]=swap;
            }
        }
    }
} 


void SelectionSort(List<int> list)
{
    int n = list.Count;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (list[j] < list[minIndex])
            {
                minIndex = j;
            }
        }
        int temp = list[minIndex];
        list[minIndex] = list[i];
        list[i] = temp;
    }
}

 void MergeSort(List<int> list)
{
    if (list.Count <= 1)
        return;

    int mid = list.Count / 2;
    List<int> left = list.GetRange(0, mid);
    List<int> right = list.GetRange(mid, list.Count - mid);

    MergeSort(left);
    MergeSort(right);
    Merge(list, left, right);
}

void Merge(List<int> list, List<int> left, List<int> right)
{
    int i = 0, j = 0, k = 0;
    while (i < left.Count && j < right.Count)
    {
        if (left[i] <= right[j])
        {
            list[k++] = left[i++];
        }
        else
        {
            list[k++] = right[j++];
        }
    }
    while (i < left.Count)
    {
        list[k++] = left[i++];
    }
    while (j < right.Count)
    {
        list[k++] = right[j++];
    }
}

 void QuickSort(List<int> list, int low, int high)
{
    if (low < high)
    {
        int pi = Partition(list, low, high);
        QuickSort(list, low, pi - 1);
        QuickSort(list, pi + 1, high);
    }
}

 int Partition(List<int> list, int low, int high)
{
    int pivot = list[high];
    int i = (low - 1);
    for (int j = low; j < high; j++)
    {
        if (list[j] < pivot)
        {
            i++;
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
    int swapTemp = list[i + 1];
    list[i + 1] = list[high];
    list[high] = swapTemp;
    return i + 1;
}
