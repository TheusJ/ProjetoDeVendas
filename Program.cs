using ProjetoDeVendas.AcessoFuncionarios;
using ProjetoDeVendas.Funcionarios;
using ProjetoDeVendas.MenuOpcoesFuncionarios;
using ProjetoDeVendas.OpcoesMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeVendas
{
    
    public class Program
    {
        public string Login;
        static void Main(string[] args)
        {
            
            
            LoginESenha LoginFun = new LoginESenha();
            {
                
            }
            MenuOp menuOp = new MenuOp();
            {
                menuOp.Vendedores = "1";
                menuOp.Produtos = "2";
                menuOp.Vender = "3";
                menuOp.Contato = "4";
                menuOp.Cadastro = "5";
                menuOp.Exit = "6";

            }
            MenuVendedores menuVendedor = new MenuVendedores();
            {
                menuVendedor.VendedoresDestaque = "1";
            }
            int opcoes = 9;
            
            Console.WriteLine("\t*****MENU VENDAS*****");
            Console.WriteLine($"{menuOp.Vendedores} VENDEDORES \n" + $"{menuOp.Produtos} PRODUTOS\n" + $"{menuOp.Vender} VENDER" + $"\n{menuOp.Contato} CONTATO\n" + $"{menuOp.Cadastro} CADASTRAR FUNCIONARIO\n" + $"{menuOp.Exit} EXIT");
            opcoes = int.Parse(Console.ReadLine());
            
            //OPÇÃO 1 É DE ACESSO A FUNCIONARIOS
            while (opcoes <= 6)
            {
                if (opcoes == 1)
                {
                    Console.WriteLine("*****ACESSO DE FUNCIONARIOS*****");

                    Console.Write("LOGIN FUNCIONARIO: ");
                    string Login1 = Console.ReadLine();
                    if (Login1 == LoginFun.Login)
                    {

                        
                        Console.Write("SENHA FUNCIONARIO: ");
                        string Senha = Console.ReadLine();
                        if (Senha == LoginFun.Senha)
                        {
                            Console.WriteLine("\t*****ACESSO CONCEDIDO*****\n");
                            Console.WriteLine($"{menuVendedor.VendedoresDestaque} VENDEDORES DESTAQUES");
                            string opcoes1 = Console.ReadLine();



                        }
                        else
                        {
                            Console.WriteLine("\nSENHA INVÁLIDA, TENTE NOVAMENTE!");
                            Console.Write("SENHA FUNCIONARIO: ");
                            Senha = Console.ReadLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine("\nLOGIN INVÁLIDO, TENTE NOVAMENTE!");
                        Console.Write("LOGIN FUNCIONARIO: ");
                        Login1 = Console.ReadLine();
                        Console.WriteLine("\nVOCÊ NÃO TEM LOGIN PARA ACESSAR O SISTEMA DE VENDAS! \nVOCÊ FOI DIRECIONADO PARA O MENU");
                        Console.WriteLine($"\n{menuOp.Vendedores} VENDEDORES \n" + $"{menuOp.Produtos} PRODUTOS\n" + $"{menuOp.Vender} VENDER" + $"\n{menuOp.Contato} CONTATO\n" + $"{menuOp.Cadastro} CADASTRAR FUNCIONARIO\n" + $"{menuOp.Exit} EXIT");
                        opcoes = int.Parse(Console.ReadLine());

                        if (Login1 == LoginFun.Login)
                        {
                            Console.WriteLine($"{menuVendedor.VendedoresDestaque} VENDEDORES DESTAQUES");
                            string opcoes1 = Console.ReadLine();
                        }
                        

                    }
                }else if(opcoes == 2)
                {

                }
                else if (opcoes == 3)
                {

                }
                else if (opcoes == 4)
                {

                }
                else if (opcoes == 5)
                {
                    Console.WriteLine("*****CADASTRO DE FUNCIONARIO*****");
                    Console.Write("DIGITE O SEU LOGIN: ");
                    string Login = Console.ReadLine();
                    
                    if (Login == LoginFun.Login)
                    {
                        Console.WriteLine("\nESTE LOGIN JÁ ESTÁ EM USO");
                        Console.Write("\nDIGITE O SEU LOGIN: ");
                        Login = Console.ReadLine();

                       
                    }
                    

                    Console.Write("\nDIGITE A SUA SENHA: ");
                    LoginFun.Senha = Console.ReadLine();


                    Console.WriteLine($"\nSeu login é: {Login}" + $" e sua senha é: {LoginFun.Senha}");
                    Console.WriteLine("\nNOME COMPLETO: ");
                    string nomesVendedores = Console.ReadLine();

                    Console.WriteLine("*****CADASTRO CONCLUIDO*****");

                    Console.WriteLine($"\n{menuOp.Vendedores} VENDEDORES \n" + $"{menuOp.Produtos} PRODUTOS\n" + $"{menuOp.Contato} CONTATO\n" + $"{menuOp.Cadastro} CADASTRAR FUNCIONARIO\n" + $"{menuOp.Exit} EXIT");
                    opcoes = int.Parse(Console.ReadLine());


                    Console.ReadLine();

                }
                else if (opcoes == 6)
                {
                    Console.WriteLine("****PROGRAMA FINALIZADO*****");
                    break;
                }
            }

            
            

        }
    }
}
