Double salario(){
    double salario;
    Console.WriteLine("digite seu salário");
    salario=Convert.ToDouble(Console.ReadLine());    
    return salario;
}
string nome(){
string nome;
Console.WriteLine("digite seu nome!");
nome=Convert.ToString(Console.ReadLine());
Console.WriteLine("bem vindo: "+nome);
return nome;
}
bool sai (){
    string ver="";
    bool exit=true;
    Console.WriteLine("deseja fazer uma consulta?");
    Console.WriteLine("digite s, para fazer, \n  ou n para sair.");
    ver=Convert.ToString(Console.ReadLine());
    if (ver=="s"){
        string name=nome();
        double grana=salario();
        menu(name,grana);
        return exit=true;
    }
    if (ver=="n"){
        Console.WriteLine("obrigado por usar este script");
        return exit=false;
    }
    return exit;
}
double aumento(double salario, double ganho){
    double conta=(salario/100)*ganho;
    conta=conta+salario;
    return conta;
}
double dado(double salario)
{
    double ganho;
    Console.WriteLine("digite quantos % quer dar de almento");
    ganho=Convert.ToDouble(Console.ReadLine());
    double mostrar=aumento(salario, ganho);
    mostrar=Math.Round(mostrar,2);
    Console.WriteLine("recebeu um aumento de: "+ganho+"% ficou com salário atual de: R$"+mostrar);
    return mostrar;
}
double dia (double salario){
    double dia=30;
    return salario/dia;
}
double hora(double salario)
{
    double dia=30;
    double hora =8;
    return salario/dia/hora;
}
double mes(double salario){
    return salario;
}
double ano(double salario){
    float ano=12;
    return salario*ano;
}
void semana(double salario, string nome){
    double semana=4;
    double calcular=salario/semana;
    Console.WriteLine(nome+"seu salário semanal é : r$"+Math.Round(calcular,2));
}
void menu(string nome,double salario){
bool i=true;
while(i!=false){
    Console.WriteLine("Digite a para ver quanto ganha por hora\n B para ver quanto ganha por dia\n C para ver quanto ganha no semana\n D quanto ganha no mês\n E para ver quanto ganha no ano\n F para calcular os ganhos no almento\n  E s para sair.");
    switch(Console.ReadLine()){
        case "a":
            double mhora=hora(salario);
            Console.WriteLine(nome+" ganha por hora: R$"+Math.Round(mhora,2));
            break;
        case"b":
            double mdia=dia(salario);
            Console.WriteLine(nome+ " ganha por dia: r$"+Math.Round(mdia,2));
            break;
        case "c":
            semana(salario,nome);
            break;        
        case "d":
            double mmes=mes(salario);
            Console.WriteLine(nome+" ganha um salário mensal de: r$"+Math.Round(mmes,2));
            break;
        case "e":
            double mano=ano(salario);
            Console.WriteLine(nome+" tem um salário anual de: r$"+Math.Round(mano,2));
            break;
        case "f":
            salario=dado(salario);
            break;
        case"s":
            i=sai();
            break;
        default:
            Console.WriteLine("opção errada, por favor digite outra!");
            break;
    }
}
}
sai();