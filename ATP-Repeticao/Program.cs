/*
double nota = 0,soma = 0, maiorNota = 0, mediaGeral; 
int alunosAprovados = 0, alunosReprovados = 0, alunosTotal= 0;

while (nota >= 0 && nota <= 100){
    Console.Write("Digite a nota (ou valor <=  para encerrar): ");
    nota = double.Parse(Console.ReadLine());
    if (nota >= 60 ) {
        alunosAprovados++; 
        soma += nota;
    }
    if (nota < 60) {
        alunosReprovados++; 
        soma += nota;
    }
    if (alunosTotal == 1 || nota > maiorNota){
        maiorNota = nota;
    }
} 
alunosTotal = alunosAprovados + alunosReprovados;
mediaGeral = soma / alunosTotal;

Console.WriteLine("\nQuantidade de estudantes aprovados: " + alunosAprovados);
Console.WriteLine("\nQuantidade de estudantes reprovados: " + alunosReprovados);
Console.WriteLine("Média de nota: " + mediaGeral);
Console.WriteLine("Maior nota: " + maiorNota);
*/

double somaSalario = 0, salario = 0, somaFilhos = 0, maiorSalario = 0, 
mediaSalario, salarioacima, mediaFilhos, percentual = 0; 
int filho = 0, habitantesTotal = 0, salariobaixo = 0;

while (filho >= 0 && salario >= 0){
    Console.WriteLine("Digite o filho: ");
    filho = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o salario: ");
    salario = double.Parse(Console.ReadLine());
    if (filho > 0 ) {
        habitantesTotal++; 
        somaFilhos += filho;
    }
    if (salario > 2000) {
        salarioacima++; 
        somaSalario += salario;
    }
    if (salario <= 2000) {
        salariobaixo++; 
        somaSalario += salario;
    }
    if (habitantesTotal == 1 || salario > maiorSalario){
        maiorSalario = salario;
    }

    mediaFilhos = somaFilhos / habitantesTotal;
    mediaSalario = somaSalario / habitantesTotal;
    percentual = salarioacima /(salarioacima + salariobaixo) * 100;
} 
