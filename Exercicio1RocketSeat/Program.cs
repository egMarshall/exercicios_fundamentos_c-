

 static void Exercicio1()
{
    Console.WriteLine("Olá! Por favor, diga seu nome:\n");

    var nome = Console.ReadLine();

    Console.WriteLine($"Olá, {nome}, Seja muito bem-vindo!");
}

 static void Exercicio2()
 {
     Console.WriteLine("Olá! Por favor, diga seu nome:\n");

     var nome = Console.ReadLine();
     
     Console.Write("Agora por favor, diga seu sobrenome:\n");
     
     var sobrenome = Console.ReadLine();

     Console.WriteLine($"Olá, {nome} {sobrenome}, Seja muito bem-vindo!");
 }

 static void Exercicio3()
 {
     Console.WriteLine("Por favor, me diga o primeiro número:\n");
     
     var firstNum = double.Parse(Console.ReadLine());
     
     Console.WriteLine("Agora por favor, me diga o segundo número:\n");
     
     var secondNum = double.Parse(Console.ReadLine());
     
     Console.WriteLine($"A soma dos dois números é {firstNum+secondNum}.\n");
     Console.WriteLine($"A subtração do primeiro número para o segundo é {firstNum - secondNum}.\n");
     Console.WriteLine($"A múltiplicação entre os dois números é {firstNum * secondNum}.\n");

     if (secondNum == 0) Console.WriteLine($"O segundo número sendo zero, o resultado sempre será zero.\n");
     else Console.WriteLine($"A divisão será {firstNum / secondNum}.\n");

     Console.WriteLine($"A média entre os dois números é {(firstNum + secondNum) / 2}.\n");
 }

 static void Exercicio4()
 {
     Console.WriteLine("Por favor, digite uma palavra:\n");
     string texto = Console.ReadLine();
     int letras = texto.Replace(" ", "").Trim().Length;
     Console.WriteLine($"A quantidade total de caractéres é de {letras} ");
 }

 static void Exercicio5()
 {
     Console.WriteLine("Por favor, digite a placa do veículo até 2018:\n");
     var placa = Console.ReadLine();
     bool placaValida = true;

     if (placa.Length != 7) placaValida = false;

     for (int i = 0; i < placa.Length; i++)
     {
         if (placa[i] < 3)
         {
             if (!char.IsLetter(placa[i])) placaValida = false;
         }

         if (placa[i] > 3 && placa[i] <= 7)
         {
             if (!char.IsDigit(placa[i])) placaValida = false;
         }
     }

     string textoValida = placaValida ? "é válida" : "não é válida";
     Console.WriteLine($"A placa {textoValida}");
 }

 static void Exercicio6()
 {
     DateTime dataAtual = DateTime.Now;
        
     Console.WriteLine("Escolha uma opção de exibição da data/hora:");
     Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
     Console.WriteLine("2 - Apenas a data no formato \"dd/MM/yyyy\"");
     Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
     Console.WriteLine("4 - A data com o mês por extenso");

     string escolha = Console.ReadLine();

     switch (escolha)
     {
         case "1":
             Console.WriteLine("Data completa: " + dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
             break;
         case "2":
             Console.WriteLine("Data (dd/MM/yyyy): " + dataAtual.ToString("dd/MM/yyyy"));
             break;
         case "3":
             Console.WriteLine("Hora (formato 24 horas): " + dataAtual.ToString("HH:mm"));
             break;
         case "4":
             Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
             break;
         default:
             Console.WriteLine("Opção inválida.");
             break;
     }
     
 }

 Exercicio1();
 Exercicio2();
 Exercicio3();
 Exercicio4();
 Exercicio5();
 Exercicio6();


