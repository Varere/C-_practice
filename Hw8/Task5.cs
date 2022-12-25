//Насколько я понял мы рассматриваем только квадратные матрицы//

Console.WriteLine("Введите сторону матрицы");
int n = int.Parse(Console.ReadLine()!);


int[,] futureSpiral = new int [n,n];
FillSpiral(futureSpiral);
Print2DArray(futureSpiral);

void FillSpiral(int[,] arr) {
    int deltaI = 0;
    int deltaJ = 0;
    int startNumber = 1;
    int even = 0;
    if(arr.GetLength(0) % 2 != 0) {
        even++;
    }
    while (arr.GetLength(0) - 2 * deltaI >= even - 2 || arr.GetLength(1) - 2 * deltaJ >= even - 2){
        int tempI = deltaI;
        int tempJ = deltaJ;
        for(int j = deltaJ; j < arr.GetLength(1) - deltaJ; j++) {
            arr[deltaI,j] = startNumber;
            startNumber++;
        }
        tempI++;
        tempJ = arr.GetLength(1) - deltaJ - 1;
        for(int i = tempI; i < arr.GetLength(0) -  deltaI; i++) {
            arr[i,tempJ] = startNumber;
            startNumber++;
        }
        tempJ--;
        tempI = arr.GetLength(0) - deltaI - 1;
        for(int j = tempJ; j >= deltaJ; j--) {
            arr[tempI,j] = startNumber;
            startNumber++;
        }
        tempJ = deltaJ;
        tempI--;
        for(int i = tempI; i > deltaI; i--) {
            arr[i,deltaJ] = startNumber;
            startNumber++;
        }
        deltaI++;
        deltaJ++;
    }
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

