
        int votos, brancos, nulos;
        int candidatoA, candidatoB;

        Console.WriteLine("*** Apuração de votos do município ***");

        Console.Write("Informe a quantidade de votos válidos: ");
        votos = int.Parse(Console.ReadLine());

        Console.Write("Total de votos do candidato A: ");
        candidatoA = int.Parse(Console.ReadLine());

        Console.Write("Total de votos do candidato B: ");
        candidatoB = int.Parse(Console.ReadLine());

        Console.Write("Informe o total de votos em branco: ");
        brancos = int.Parse(Console.ReadLine());

        Console.Write("Informe o total de votos nulos: ");
        nulos = int.Parse(Console.ReadLine());

        

        Console.WriteLine($"\nTotal de {votos} votos válidos");
        Console.WriteLine($"{brancos} votos em branco e {nulos} votos nulos");

        Console.WriteLine($"\nPercentual do candidato A: {percA:F2}%");
        Console.WriteLine($"Percentual do candidato B: {percB:F2}%");
     

        // Convertendo para double para evitar divisão inteira
        double percA = (double)candidatoA / votos * 100;
        double percB = (double)candidatoB / votos * 100;
        double nulo = (double)nulos / votos * 100;
        double branco = (double)brancos / votos * 100;
        
        if (PercA > 50)
        {
            total = (double)PercA + nulo + branco;
        }
        else
        {
            total = (double)percB + nulo + branco;
        }

        Console.WriteLine("")
