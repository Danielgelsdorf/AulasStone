float dia (float salario){
    float dia=30;
    return salario/dia;
}
float hora(float salario){
    float dia=30;
    float hora =8;
    return salario/dia/hora;
}
float mes(float salario){
    return salario;
}
float ano(float salario){
    float ano=12;
    return salario*ano;
}
int salario;
string i="a";
string nome;
Console.WriteLine("digite seu nome!");
nome=Convert.ToString(Console.ReadLine());
Console.WriteLine($"bem vindo{nome}",nome);
Console.WriteLine("digite seu salário");
salario=Convert.ToInt32(Console.ReadLine());
while(i!="s"){
    Console.WriteLine("digite a para ver quanto ganha por dia\n b para ver quanto ganha por hora\n c para ver quanto ganha no mês\n d quanto ganha no ano \n e s para sair.");
    switch(i=Convert.ToString(Console.ReadLine())){
        case"a":
            float mdia=dia(salario);
            Console.WriteLine($"ganha no dia{mdia}",mdia);
            break;
        case "b":
            float mhora=hora(salario);
            Console.WriteLine($"ganha por hora{mhora}",mhora);
            break;
        case "c":
            float mmes=mes(salario);
            Console.WriteLine($"salário mensal{mmes}",mmes);
            break;
        case "d":
            float mano=ano(salario);
            Console.WriteLine($"seu salário anual é:{mano}",mano);
            break;
        case"s":
            Console.WriteLine("obrigado por usar o programa.");
            break;
        default:
            Console.WriteLine("opção errada, por favor digite outra!");
            break;
    }
}