

Random r = new Random();


int[,] randomTwoDimensionalArray(int n, int m){
    int [,] arr = new int[n,m];

    for(int i = 0; i<=n;i++ ){
        for(int j = 0;j<=m;j++){
            arr[i,j]= r.Next(1,9);
        }
    }

    return arr;
}


void findToArray(int n, int m){
    int [,] arr = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};

if(n>10 | m>3){
    Console.WriteLine("Такого элемента нет в массиве");
}else{
    int result =  arr[n,m];
    Console.WriteLine(result);

 }    
}

findToArray(4,6);
findToArray(0,0);


int[,] arr2 = {{1,2,3},{4,5,6},{7,8,9}};

// int index = arr2.GetUpperBound(0)+1;
// int len  = arr2.Length/index;
//  Console.WriteLine(len);

 void getAverage(int[,] n){
int index = n.GetUpperBound(0)+1;
int len  = n.Length/index;
 Console.WriteLine(len);
int x = 0;
int ave;

    for(int i = 0; i<=len-1;i++ ){
        ave = 0;
        x = 0;
        for(int j = 0;j<=index-1;j++){
            x += n[j,i]; 
        }
        ave = x/index;
Console.WriteLine(ave);
    }
}

getAverage(arr2);


