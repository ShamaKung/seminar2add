Console.WriteLine("Введите координаты точки А: ");
int[] A = new int[3];

for(int i = 0; i < A.Length; i++)
{
    A[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите координаты точки B: ");
int[] B = new int[3];

for(int i = 0; i < B.Length; i++)
{
    B[i] = int.Parse(Console.ReadLine());
}

double sum = Math.Sqrt(Math.Pow(A[0] - B[0],2) + Math.Pow(A[1] - B[1],2) + Math.Pow(A[2] - B[2],2));
Console.WriteLine("Растояние между точками " + sum);