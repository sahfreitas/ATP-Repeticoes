/*
1. Uma escola deseja registrar as notas finais dos alunos em
uma disciplina. Faça um algoritmo que leia as notas (entre 0
e 100) de diversos alunos e mostre ao final:
  A quantidade de alunos aprovados (nota ≥ 60)
  A quantidade de alunos reprovados (nota < 60)
  A média geral da turma
  A maior nota registrada
 A entrada termina quando for digitado um valor negativo.
*/

/*
double nota = 0,soma = 0, maiorNota = 0, mediaGeral; 
int alunosAprovados = 0, alunosReprovados = 0, alunosTotal= 0;

while (nota >= 0 && nota <= 100){
    Console.Write("Digite a nota (ou valor negativo para encerrar): ");
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
/*
2. A prefeitura de uma cidade fez uma pesquisa entre seus
habitantes, coletando dados sobre o salário e número de
filhos de cada habitante. A prefeitura deseja saber:
  média do salário da população;
  média do número de filhos;
  maior salário;
  percentual de pessoas com salário até R$ 2.000,00.
 O final da leitura de dados se dará com a entrada de um
salário negativo.
*/

double somaSalario = 0, salario = 0, somaFilhos = 0, maiorSalario = 0,
mediaSalario, salarioacima = 0, mediaFilhos, percentual = 0;
int filho = 0, habitantesTotal = 0, salariobaixo = 0;

while (filho >= 0 && salario >= 0){
    Console.WriteLine("Digite o filho: ");
    filho = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o salario: ");
    salario = double.Parse(Console.ReadLine());
    if (filho >= 0 ) {
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
} 
    mediaFilhos = somaFilhos / habitantesTotal;
    mediaSalario = somaSalario / habitantesTotal;
    percentual = salarioacima /(salarioacima + salariobaixo) * 100;

    Console.WriteLine("\nMédia do salário da população: " + mediaSalario);
    Console.WriteLine("\nMédia do número de filhos: " + mediaFilhos);
    Console.WriteLine("Maior salário: " + maiorSalario);
    Console.WriteLine("Percentual de pessoas com salário até R$ 2.000,00: " + percentual);
