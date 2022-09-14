// See https://aka.ms/new-console-template for more information
int [,] MainArray = new int[4,4];
int [,] ResultArray = ArrayCreation();





int [,] ArrayCreation()
{
    
        for(int i = 0; i<MainArray.GetLength(0); i++)
        {
            for(int j = 0; j<MainArray.GetLength(1);j++)
            {
                MainArray[i,j] = new Random().Next(0,10);
                Console.Write($"{MainArray[i,j]} ");
            }
           Console.WriteLine();
        }
        return MainArray;
}

int [,] SwapPlace(int [,]ResultArray)
{
    int RowCount = ResultArray.GetLength(0)-1;
    for(int i = 0; i<ResultArray.GetLength(1);i++)
    {
        int k = ResultArray[0,i];
        ResultArray[0,i] = ResultArray[RowCount,i];
        ResultArray[RowCount,i] =  k;
    }
    return ResultArray;

}
Console.Write($"{SwapPlace(ResultArray)}");
