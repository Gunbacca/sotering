List<int>tal= new List<int>();
tal.Add(1);
tal.Add(3);
tal.Add(2);
tal.Add(7);
tal.Add(5);
for(int i=0; i<tal.Count; i++){
    for(int j=0; j<tal.Count-1-i; j++){
        if(tal[j]>tal[j+1]){
            int swap= j;
            j=i;
            i=swap;
        }
    }
}
