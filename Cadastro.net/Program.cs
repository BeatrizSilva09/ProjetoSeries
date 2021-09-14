using Cadastro.net.Enum;
using System;
using Cadastro.net.Interface;
    
namespace Cadastro.net
{
    class Program
    {
        static SerieRepositorio Repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = OpcUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                        VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = OpcUsuario();
            }
            Console.WriteLine("Volte Sempre");
            Console.ReadLine();

        }
    


        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");
            var lista = Repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i  in Genero.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o criador da série");
            string entradaCriador = Console.ReadLine();


            Series novaSerie = new Series(Id: Repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         ano: entradaAno,
                                         descricao: entradaDescricao,
                                         criador: entradaCriador);


        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (int i in Genero.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite quem é o criador da série");
            string entradaCriador = Console.ReadLine();

            Series atualizaSerie = new Series(Id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        criador: entradaCriador);

            Repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
       
        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o Id da série");
            int indiceSerie = int.Parse(Console.ReadLine());
            Repositorio.Exclui(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o Id da série");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = Repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);

        }





        private static string OpcUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Catálogo de séries");
            Console.WriteLine("Informe a sua escolha: ");

            Console.WriteLine(" 1 - Listar séries");
            Console.WriteLine(" 2 - Inserir nova série");
            Console.WriteLine(" 3 - Atualizar séries");
            Console.WriteLine(" 4 - Excluir série");
            Console.WriteLine(" 5 - Visualizar série");
            Console.WriteLine(" C - Limpar tela");
            Console.WriteLine(" X - Sair");
            Console.WriteLine();

            string opcUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcUsuario;




        }
    }
    }
