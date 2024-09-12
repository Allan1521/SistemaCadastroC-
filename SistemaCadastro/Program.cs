using System; // Importa o namespace System, que contém classes fundamentais para o uso do console.
using System.Collections.Generic; // Importa o namespace para utilizar coleções genéricas, como List.

namespace CadastroCliente // Declara o namespace para o programa, agrupando classes relacionadas.
{
    class Program // Declara a classe principal do programa.
    {
        // Declara a classe Cliente para representar um cliente com propriedades específicas.
        class Cliente
        {
            public string Nome { get; set; } // Propriedade para o nome do cliente, do tipo string.
            public int Idade { get; set; } // Propriedade para a idade do cliente, do tipo inteiro.
            public string Email { get; set; } // Propriedade para o email do cliente, do tipo string.
            public double Saldo { get; set; } // Propriedade para o saldo do cliente, do tipo double.
        }

        static void Main(string[] args) // Método principal onde a execução do programa começa.
        {
            // Cria uma lista para armazenar objetos do tipo Cliente.
            List<Cliente> clientes = new List<Cliente>();

            // Loop infinito para exibir o menu até o utilizador escolher sair.
            while (true)
            {
                // Exibe o menu principal no console.
                Console.WriteLine("\n--- Sistema de Cadastro de Clientes ---");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Mostrar Clientes");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                // Lê a opção digitada pelo utilizador.
                string opcao = Console.ReadLine();

                if (opcao == "1") // Se o utilizador escolher a opção 1, realiza o cadastro de um novo cliente.
                {
                    // Cria um novo objeto Cliente.
                    Cliente novoCliente = new Cliente();

                    // Solicita o nome do cliente e atribui o valor digitado à propriedade Nome.
                    Console.Write("Digite o nome do cliente: ");
                    novoCliente.Nome = Console.ReadLine();

                    // Solicita a idade do cliente e converte o valor digitado para inteiro.
                    Console.Write("Digite a idade do cliente: ");
                    novoCliente.Idade = int.Parse(Console.ReadLine());

                    // Solicita o email do cliente e atribui o valor digitado à propriedade Email.
                    Console.Write("Digite o email do cliente: ");
                    novoCliente.Email = Console.ReadLine();

                    // Solicita o saldo inicial do cliente e converte o valor digitado para double.
                    Console.Write("Digite o saldo inicial do cliente: ");
                    novoCliente.Saldo = double.Parse(Console.ReadLine());

                    // Adiciona o novo cliente à lista de clientes.
                    clientes.Add(novoCliente);

                    // Exibe uma mensagem de confirmação.
                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                }
                else if (opcao == "2") // Se o utilizador escolher a opção 2, exibe a lista de clientes cadastrados.
                {
                    // Exibe o título da lista de clientes.
                    Console.WriteLine("\n--- Lista de Clientes ---");

                    // Verifica se existem clientes cadastrados na lista.
                    if (clientes.Count == 0)
                    {
                        // Se não houver clientes, exibe uma mensagem informativa.
                        Console.WriteLine("Nenhum cliente cadastrado.");
                    }
                    else
                    {
                        // Se houver clientes, percorre cada cliente na lista.
                        foreach (Cliente cliente in clientes)
                        {
                            // Exibe os detalhes do cliente.
                            Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}, Email: {cliente.Email}, Saldo: {cliente.Saldo}");
                        }
                    }
                }
                else if (opcao == "3") // Se o utilizador escolher a opção 3, termina o programa.
                {
                    // Exibe uma mensagem de saída e termina o loop.
                    Console.WriteLine("Saindo do sistema...");
                    break; // Interrompe o loop 'while' e termina o programa.
                }
                else
                {
                    // Se o utilizador inserir uma opção inválida, exibe uma mensagem de erro.
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }
    }
}
