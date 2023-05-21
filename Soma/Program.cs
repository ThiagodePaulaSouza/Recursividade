int Soma(int N, List<int> A)
{
    if (N == 0)
    {
        return 0;
    }
        return Soma(N - 1, A) + A[N];
}

var lista = new List<int>()
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10,
};

var resultado1 = Soma(5, lista);
Console.WriteLine(resultado1);
Console.ReadLine();