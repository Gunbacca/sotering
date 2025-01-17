using System.Diagnostics;
/*
List<int>tal= new List<int>();
tal.Add(1);
tal.Add(3);
tal.Add(2);
tal.Add(2);
tal.Add(53);
tal.Add(95);
tal.Add(12);
tal.Add(88);
tal.Add(23);
tal.Add(44);
*/
List<int> tal=Enumerable.Range(1,1000).ToList();


 Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        BubbleSort(tal);

        stopwatch.Stop();

        Console.WriteLine($"Tiden för loopen att köra: {stopwatch.Elapsed.Microseconds} μs");
    

void BubbleSort(List<int>bubble){
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