Console.WriteLine("Escolha uma classe: ");
Console.WriteLine("1 - Guerreira");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueira");
int classe = Convert.ToInt32(Console.ReadLine());
switch (classe){ 
     case 1:
    Console.WriteLine("Suas habilidades sao: Ataque Pesado e defesa Total");
    break;
                
    case 2:
    Console.WriteLine("Suas habilidades sao: bola de Fogo e escudo de Gelo");
    break;
   
    case 3:
    Console.WriteLine("Suas habilidades sao: flecha Precisa e disparo Triplo");
    break;
                
    default:
    Console.WriteLine("Opção inválida!");
    break;
}

