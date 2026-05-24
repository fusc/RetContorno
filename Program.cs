string continuar = "s";
while (continuar == "s")
{



Console.WriteLine("Tamanho do retângulo"); 

Console.Write("Largura: ");
int largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura: "); 
int altura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(); 

int contadorlinha = 0;
while (contadorlinha < altura)
{
    int contadorcoluna = 0;
    while (contadorcoluna < largura)
    {
        if (contadorlinha == 0 || contadorlinha == altura - 1 || contadorcoluna == 0 || contadorcoluna == largura - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" "); 
        }
        
        contadorcoluna = contadorcoluna + 1;
    }
    Console.WriteLine();
    contadorlinha = contadorlinha + 1;
}
Console.Write("Deseja executar novamente? (S/N)?");
continuar = Console.ReadLine()!.ToLower();
}
Console.WriteLine("muito obrigado por usar o programa!");