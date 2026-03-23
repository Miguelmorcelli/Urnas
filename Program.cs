// Validação de percentuais de uma eleição
// Criação e inicialização das variáveis
int votos, brancos, nulos = 0;
int candidatoA, candidatoB = 0;
double total = 0;

// Solicitação de dados do usuário
System.Console.WriteLine("*** Apuração de votos do município ***"); ;
System.Console.Write("Informe a quantidade de votos válidos: ");
votos = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Total de votos do candidato A: ");
    candidatoA = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Agora, o total de votos do candidato B: ");
    candidatoB = Convert.ToInt16(Console.ReadLine());



Console.Write("Informe o total de votos em branco: ");
brancos = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o total de votos nulos: ");
nulos = Convert.ToInt32(Console.ReadLine());

double PercA = (double) candidatoA / votos * 100;
double PercB = (double) candidatoB / votos * 100;
double nulo = (double) nulos / votos * 100;
double branco = (double) brancos / votos * 100;

if (PercA > 50)
{

     total = (double) PercA + nulo + branco;

}
else 
{

     total = (double) PercB + nulo + branco;    

}

System.Console.WriteLine("Total de votos válidos: " +votos+ "\n" +
                         "Total de votos nulos: " +nulos+ "\n "+
                         "Total de votos em branco: " +brancos+ "\n" +
                         "Porcentagem candidato A: " +PercA+ "%" + "\n"+
                         "Porcentagem candidato B: " +PercB+ "%");

 Console.WriteLine($"O candidato vencedor teve {total} %");
