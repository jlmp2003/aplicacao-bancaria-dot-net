using System;
using System.Collections.Generic;

namespace Dio.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {
            //Conta minhaconta = new Conta(TipoConta.PessoaFisica, 0, 0, "Teste Titular");
            //Console.WriteLine(minhaconta);
            string opcaoUsuario = ObterOpcaoUsuaro();

            while (opcaoUsuario.ToUpper() != "X")
                {

                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirContas();
                        break;
                    case "3":
                        Tranferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentException();
                }
                opcaoUsuario = ObterOpcaoUsuaro();
            }
        }

        private static void Tranferir()
        {
            Console.WriteLine("Difite o numero da conta de origem");
            int indicecontaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Difite o numero da conta de destino");
            int indicecontaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Difite o valor a ser transferido");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indicecontaOrigem].Transferir (valorTransferencia , listContas[indicecontaDestino]);
        }

        private static void Sacar()
        {
            Console.WriteLine("Difite o numero da conta");
            int indiceconta = int.Parse(Console.ReadLine());

            Console.WriteLine("Difite ovalor a sacar");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceconta].Sacar(valorSaque);
        }

        private static void Depositar()
        {

            Console.WriteLine("Difite o numero da conta");
            int indiceconta = int.Parse(Console.ReadLine());

            Console.WriteLine("Difite ovalor a sacar");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceconta].Depositar(valorDeposito);
        }

        private static void InserirContas()
        {
            Console.WriteLine("Inserir nova conta");
            Console.WriteLine("Digite 1 para conta Fisica  ou2 pra Juridica");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Cliente");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial");
            double entradqSaldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Creditol");
            double entradqCredito = int.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                saldo: entradqSaldo,
                credito: entradqCredito,
                nome: entradaNome);
            listContas.Add(novaConta);

        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");
            if(listContas.Count ==0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }
            for (int i=0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.WriteLine("'#{0}     " , i);
                Console.WriteLine(conta);

            }


        }

        private static string ObterOpcaoUsuaro()
        {

            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu dispor !!!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Tranferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;



        }

    }
}
