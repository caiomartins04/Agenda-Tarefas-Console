using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //Abertura do programa.
            Console.WriteLine("AGENDA DE TAREFAS C#\n\n");
            Console.Write("Numero de Tarefas: ");
            int numero_tarefas = int.Parse(Console.ReadLine());
            Console.Write("\n");
            //Vetores
            string[] titulo_tarefa = new string[numero_tarefas];
            string[] descricao_tarefa = new string[numero_tarefas];
            string[] data = new string[numero_tarefas];
            string[] prioridade = new string[numero_tarefas];
            int[] hinicio = new int[numero_tarefas];
            int[] hfim = new int[numero_tarefas];
            int[] status = new int[numero_tarefas];
            int[] hgasta = new int[numero_tarefas];

            //Variáveis simples
            int totaltarefas = numero_tarefas;
            int feito = 0, naofeito = 0;
            float porcentfeito, feito2 = 0, todas_taref = 0, htotal = 0;

            Console.WriteLine("Carregando....");
            Console.WriteLine("Preencha o formulário");
            Console.WriteLine("Obs: Para horários, utilize números inteiros(intuito de aproximação) e que representem período ativo. (5 às 23) \n");

            //Loop para receber as informações
            for (int i = 0; i < numero_tarefas; i++)
            {
                 Console.WriteLine("\n**LISTA DE TAREFAS**\n");

                 Console.Write("Título da Tarefa: ");
                 titulo_tarefa[i] = Console.ReadLine();

                 Console.Write("Descrição da Tarefa: ");
                 descricao_tarefa[i] = Console.ReadLine();

                 Console.Write("Data: ");
                 data[i] = Console.ReadLine();

                 //Horários medidos aproximadamente e em números inteiros.
                 do
                 {
                     Console.Write("Hora Inicio: ");
                     hinicio[i] = int.Parse(Console.ReadLine());

                 }while(hinicio[i] >23);
                do
                {
                    Console.Write("Hora Fim: ");
                    hfim[i] = int.Parse(Console.ReadLine());

                }while(hfim[i] >23 || hfim[i] < hinicio[i]);

                Console.Write("Prioridade(Alta,Média ou Baixa): ");
                prioridade[i] = Console.ReadLine();

                Console.Write("Status(1=Feito ou 2=Não feito): ");
                status[i] = int.Parse(Console.ReadLine());

                Console.Write("\n\n");

                //Operação para calcular porcentagem de tarefas realizadas
                if (status[i]==1)
                 {
                     feito++;
                 }
                if (status[i]==2)
                {
                    naofeito++;
                }

                //Operação pra calcular total de horas por dia
                hgasta[i] = hfim[i] - hinicio[i];
                  
            }
            Console.Write("\n\n\n");

            //Operação para calcular porcentagem de tarefas realizadas
            feito2 = feito;
            todas_taref = numero_tarefas;
            porcentfeito = feito2 / todas_taref * 100;

            Console.WriteLine("***AGENDA PRONTA***");
            Console.Write("\n\n");

            //Loop para mostrar as informações prontas.
            for (int i = 0; i < numero_tarefas; i++)
            {
               
                Console.WriteLine("TÍTULO DA TAREFA: " + titulo_tarefa[i]);
                Console.WriteLine("DESCRIÇÃO DA TAREFA: " + descricao_tarefa[i]);
                Console.WriteLine("DATA: " + data[i]);
                Console.WriteLine("HORA INICIO: " + hinicio[i]);
                Console.WriteLine("HORA FIM: " + hfim[i]);
                Console.WriteLine("PRIORIDADE: " + prioridade[i]);
                Console.WriteLine("STATUS: " + status[i]);
                Console.WriteLine("TEMPO GASTO (NESTA) TAREFA: "  + "Aproximadamente "+ hgasta[i] + " hora(s).");
                Console.Write("\n\n");
            }
            //Calculando o tempo gasto em todas as tarefas
            for(int i = 0; i < numero_tarefas; i++)
            {
                htotal = htotal + hgasta[i];
            }
            //Mostrando ao usuário as últimas informações necessárias (RESUMO)
            Console.Write("\n");
            Console.WriteLine("RESUMO");
            Console.WriteLine("Total: " + numero_tarefas + " tarefa(s).");
            Console.WriteLine(feito + " foram concluídas e " + naofeito + " não.");
            Console.WriteLine(porcentfeito + "% das tarefas já foram concluídas.");
            Console.WriteLine("TEMPO GASTO EM (TODAS) TAREFAS:  "  + "Aproximadamente "+ htotal + " hora(s).");

            Console.ReadLine();
        }
        
    }
}
