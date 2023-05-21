static int Soma(int N, List<int> A) => N == 0 ? 0 : Soma(N - 1, A) + A[N];

List<int> lista = new()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

var resultado1 = Soma(5, lista);
Console.WriteLine(resultado1);
Console.ReadLine();