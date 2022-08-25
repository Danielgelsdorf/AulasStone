string i="a";
float dia = 20;
var total = 30.0;
float hora;
float ano=12;
string nome;
float salario;
Console.WriteLine("digite seu nome");
nome =Console.ReadLine();
Console.WriteLine($"bem vindo: {nome}\n", nome);
Console.WriteLine("digite seu salário");
salario = Convert.ToInt32(Console.ReadLine());
while( i !="s"){
    Console.WriteLine("escolha sua opção");
    Console.WriteLine("Digite A quanto ganho por hora\n");
    Console.WriteLine("Digite D para ver quanto ganho por cemana.\n");
    Console.WriteLine("digite C para ver quanto ganha no mes\n");
    Console.WriteLine("digite D para ver quanto ganha no dia\n");
    Console.WriteLine("digite E para ver quanto ganha no ano\n");
    Console.WriteLine("Digite S para sair");
    switch(i=Console.ReadLine())
    {
        case "a":
            hora = salario / 20 / 8;
            Console.WriteLine($"ganha por hora{hora}", hora);
            break;
        case "b":
            total = salario / 4;
            Console.WriteLine($"seu salário na semana é: {total}", total);
            break;
        case "c":
            Console.WriteLine($"ganhos mensais:{salario}", salario);
            break;
        case "d":
            dia = (salario / dia);
            Console.WriteLine($"salario  diário:{dia}", dia);
            break;
        case "e":
            ano = salario * ano;
            Console.WriteLine($"salario anual: {ano}", ano);
            break;
        case "s":
            Console.WriteLine("obrigado por usar o programa.");
            break;
        default:
            Console.WriteLine("opção errada, por favor digite a opção correta.");
            break;
    }
}