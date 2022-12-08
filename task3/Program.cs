void Cube (int[] arr, int len)
{
    for(int i=0; i < len; i++)
    {
        double cubeNumber = Math.Pow(arr[i],3);
        Console.WriteLine(cubeNumber);
    }
}


Console.WriteLine("Введите число");
int lengthA = int.Parse(Console.ReadLine());
int[] A = new int[lengthA];

for(int i = 0; i < A.Length; i++)
{
    A[i] = i + 1;
}

Cube(A, lengthA);