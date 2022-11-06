using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaquinaDeVenda_C_.Models
{

    public class VendingMachine
    {
      
        public int Count { get; set; }
        public int Capacity { get; set; }
        public int moneyCollected { get; set; }
        public string manuFacturer { get; set; }


        public void Display( decimal valor)
        {
            Console.WriteLine("*********************Bem vindo a maquina de venda********************* \n");
            Console.WriteLine("Digite o valor que deseja inserir");
            valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O valor inserido foi de: " + valor);
            Console.WriteLine("Digite o codigo do produto que deseja comprar");
            Console.WriteLine("1 - Coca-Cola");
            Console.WriteLine("2 - Fanta");
            Console.WriteLine("3 - Sprite");
            Console.WriteLine("4 - Guaraná");
            Console.WriteLine("5 - Água");
            Console.WriteLine("6 - Suco");
            Console.WriteLine("7 - Refrigerante");
            Console.WriteLine("8 - Cerveja");
            Console.WriteLine("9 - Vinho");
            Console.WriteLine("10 - Whisky");
            Console.WriteLine("11 - Vodka");
            Console.WriteLine("12 - Tequila");
            Console.WriteLine("13 - Energético");
            Console.WriteLine("14 - Café");
            Console.WriteLine("15 - Chá");
            Console.WriteLine("16 - Leite");
            Console.WriteLine("17 - Iogurte");
            Console.WriteLine("18 - Queijo");
            Console.WriteLine("19 - Presunto");
            Console.WriteLine("20 - Salame");
            Console.WriteLine("21 - Salgadinho");
            Console.WriteLine("22 - Biscoito");
            Console.WriteLine("23 - Bolacha");
            Console.WriteLine("24 - Pão");
            Console.WriteLine("25 - Pizza");
            Console.WriteLine("26 - Hamburguer");
            Console.WriteLine("27 - Hot-Dog");
            Console.WriteLine("28 - Sanduíche");
            Console.WriteLine("29 - Batata-Frita");
            Console.WriteLine("30 - Batata-Suco");
            Console.WriteLine("31 - Batata-Recheada");
            Console.WriteLine("32 - Batata-Salgada");
            Console.WriteLine("33 - Batata-Doce");
            Console.WriteLine("34 - Batata-Chips");
            Console.WriteLine("35 - Batata-Palha");
            Console.WriteLine("36 - Batata-Rústica");
            Console.WriteLine("37 - Batata-Suculenta");
            Console.WriteLine("38 - Batata-Salgadinha");
            Console.WriteLine("O produto escolhido foi: " + Console.ReadLine());
            if (valor == 1)
            {
                Console.WriteLine("Coca-Cola");
            }
            else if (valor == 2)
            {
                Console.WriteLine("Fanta");
            }
            else if (valor == 3)
            {
                Console.WriteLine("Sprite");
            }
            else if (valor == 4)
            {
                Console.WriteLine("Água com Gás");
            }
            else if (valor == 5)
            {
                Console.WriteLine("Água");
            }
            else if (valor == 6)
            {
                Console.WriteLine("Suco-Tampico-Laranja");
            }
            else if (valor == 7)
            {
                Console.WriteLine("Stella-Artois-Long-Neck");
            }
            else if (valor == 8)
            {
                Console.WriteLine("Bohemia-420ML");
            }
            else if (valor == 9)
            {
                Console.WriteLine("Vinho");
            }
            else if (valor == 10)
            {
                Console.WriteLine("Whisky");
            }
            else if (valor == 11)
            {
                Console.WriteLine("Skol-420ML");
            }
            else if (valor == 12)
            {
                Console.WriteLine("Brahma-420ML");
            }
            else if (valor == 13)
            {
                Console.WriteLine("Energético");
            }
            else if (valor == 14)
            {
                Console.WriteLine("Cappuccino");
            }
            else if (valor == 15)
            {
                Console.WriteLine("Chá-Matte");
            }
            else if (valor == 16)
            {
                Console.WriteLine("Budweiser-Long Neck");
            }
            else if (valor == 17)
            {
                Console.WriteLine("Iogurte");
            }
            else if (valor == 18)
            {
                Console.WriteLine("Heineken-Long Neck");
            }
            else if (valor == 19)
            {
                Console.WriteLine("Bala-Mentos");
            }
            else if (valor == 20)
            {
                Console.WriteLine("Baconzitos");
            }
            else if (valor == 21)
            {
                Console.WriteLine("Salgadinho-Torcida");
            }
            else if (valor == 22)
            {
                Console.WriteLine("Redbull");
            }
            else if (valor == 23)
            {
                Console.WriteLine("Guaraná Antarctica");
            }
            else if (valor == 24)
            {
                Console.WriteLine("Suco-Belga");
            }
            else if (valor == 25)
            {
                Console.WriteLine("Biscoito");
            }
            else if (valor == 26)
            {
                Console.WriteLine("Bala-Halls");
            }
            else if (valor == 27)
            {
                Console.WriteLine("Trident");
            }
            else if (valor == 28)
            {
                Console.WriteLine("Sanduíche-Natural");
            }
            else if (valor == 29)
            {
                Console.WriteLine("Cebolitos");
            }
            else if (valor == 30)
            {
                Console.WriteLine("Batata-Ruffles");
            }
            else if (valor == 31)
            {
                Console.WriteLine("Batata-Ruffles-Churrasco");
            }
            else if (valor == 32)
            {
                Console.WriteLine("Fandangos");
            }
            else if (valor == 33)
            {
                Console.WriteLine("Chocolate");
            }
            else if (valor == 34)
            {
                Console.WriteLine("Sukita");
            }
            else if (valor == 35)
            {
                Console.WriteLine("Caixa de BIS");
            }
            else if (valor == 36)
            {
                Console.WriteLine("Batata-Rústica");
            }
            else if (valor == 37)
            {
                Console.WriteLine("MM'S");
            }
            else if (valor == 38)
            {
                Console.WriteLine("Guaraná-Kuat");
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }

        }
        public void DispenseProducts( int valor)
        {
            if (valor == 1)
            {
                Console.WriteLine("Coca-Cola");
            }
            else if (valor == 2)
            {
                Console.WriteLine("Fanta");
            }
            else if (valor == 3)
            {
                Console.WriteLine("Sprite");
            }
            else if (valor == 4)
            {
                Console.WriteLine("Guaraná");
            }
            else if (valor == 5)
            {
                Console.WriteLine("Água");
            }
            else if (valor == 6)
            {
                Console.WriteLine("Suco");
            }
            else if (valor == 7)
            {
                Console.WriteLine("Refrigerante");
            }
            else if (valor == 8)
            {
                Console.WriteLine("Cerveja");
            }
            else if (valor == 9)
            {
                Console.WriteLine("Vinho");
            }
            else if (valor == 10)
            {
                Console.WriteLine("Whisky");
            }
            else if (valor == 11)
            {
                Console.WriteLine("Vodka");
            }
            else if (valor == 12)
            {
                Console.WriteLine("Tequila");
            }
            else if (valor == 13)
            {
                Console.WriteLine("Energético");
            }
            else if (valor == 14)
            {
                Console.WriteLine("Café");
            }
            else if (valor == 15)
            {
                Console.WriteLine("Chá");
            }
            else if (valor == 16)
            {
                Console.WriteLine("Leite");
            }
            else if (valor == 17)
            {
                Console.WriteLine("Iogurte");
            }
            else if (valor == 18)
            {
                Console.WriteLine("Queijo");
            }
            else if (valor == 19)
            {
                Console.WriteLine("Presunto");
            }
            else if (valor == 20)
            {
                Console.WriteLine("Salame");
            }
            else if (valor == 21)
            {
                Console.WriteLine("Salgadinho");
            }
            else if (valor == 22)
            {
                Console.WriteLine("Biscoito");
            }
            else if (valor == 23)
            {
                Console.WriteLine("Bolacha");
            }
            else if (valor == 24)
            {
                Console.WriteLine("Pão");
            }
            else if (valor == 25)
            {
                Console.WriteLine("Pizza");
            }
            else if (valor == 26)
            {
                Console.WriteLine("Hamburguer");
            }
            else if (valor == 27)
            {
                Console.WriteLine("Hot-Dog");
            }
            else if (valor == 28)
            {
                Console.WriteLine("Sanduíche");
            }
            else if (valor == 29)
            {
                Console.WriteLine("Batata-Frita");
            }
            else if (valor == 30)
            {
                Console.WriteLine("Batata-Suco");
            }
            else if (valor == 31)
            {
                Console.WriteLine("Batata-Recheada");
            }
            else if (valor == 32)
            {
                Console.WriteLine("Batata-Salgada");
            }
            else if (valor == 33)
            {
                Console.WriteLine("Batata-Doce");
            }
            else if (valor == 34)
            {
                Console.WriteLine("Batata-Chips");
            }
            else if (valor == 35)
            {
                Console.WriteLine("Batata-Palha");
            }
            else if (valor == 36)
            {
                Console.WriteLine("Batata-Rústica");
            }
            else if (valor == 37)
            {
                Console.WriteLine("Batata-Suculenta");
            }
            else if (valor == 38)
            {
                Console.WriteLine("Batata-Salgadinha");
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }
        {
            if (Count > 0)
            {
                Count--;
                Console.WriteLine("Produto comprado com sucesso");
            }
            else
            {
                Console.WriteLine("Produto indisponivel");
            }
        }
    }

        public void DispenseProducts()
        {
            if (Count > 0)
            {
                Count--;
                Console.WriteLine("Produto comprado com sucesso");
            }
            else
            {
                Console.WriteLine("Produto indisponivel");
            }
        }
        public void RefillProducts()
        {
            Count = 10;
            Console.WriteLine("Produto recarregado com sucesso");
        }
    }
}