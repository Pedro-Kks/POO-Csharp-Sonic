using System;

namespace Consopro
{

    class Sonic
    {
        //Atributos
        public string Nome { get; set; }
        public int Rings { get; set; }
        public int Esmeraldas { get; set; }
        public List<string> Transformacoes { get; set; }
        private Random rnd = new Random();



        //Construtor
        public Sonic(string nome, int rings, int esmeraldas)
        {
            this.Nome = nome;
            this.Rings = rings;
            this.Esmeraldas = esmeraldas;
            this.Transformacoes = new List<string>
            {
                "Super Sonic", "Lobo Ourinço", "Hyper Sonic"
            };
        }

        //Método
        public void PegarRingsEsmeraldas(int quantidadeRings, int numEsmeraldas)
        {
            Console.WriteLine($"O {this.Nome} precisa pegar 7 Esmeraldas do Caos e coletar mais de 100 Anéis(Rings) para se transformar em {string.Join(", ", this.Transformacoes)}.");
            Console.WriteLine("======================================================================================");

            Console.WriteLine($"O {this.Nome} pegou {this.Rings += quantidadeRings} rings.");
            Console.WriteLine($"O {this.Nome} pegou {this.Esmeraldas += numEsmeraldas} esmeraldas.");

            Console.WriteLine("======================================================================================");
            
            string transformacao = this.Transformacoes[rnd.Next(this.Transformacoes.Count)];
            if (numEsmeraldas == 7 && quantidadeRings > 100)
            {
                Console.WriteLine($"Com isso o {this.Nome} se transformou em {transformacao}! E ataca Robotnik com o controle do Caos.🔥");
                Console.WriteLine($"O {this.Nome} ganhou e derrotou o Dr.Robotnik! 🤖");
            }
            else
            {
                Console.WriteLine($"🤖 Dr.Robotnik roubou {7 - numEsmeraldas} esmeraldas.💎");
                if (numEsmeraldas == 7 && quantidadeRings < 100)
                {
                    Console.WriteLine($"O {this.Nome} não tem anéis suficientes para se transformar com as esmeraldas coletadas.💎");
                    Console.WriteLine($"Por tanto não consegue se transformar.");

                }
                else
                {
                    Console.WriteLine($"O {this.Nome} precisa derrotar Robotnik (Eggman) para recuperar as esmeraldas restantes!💎");
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Criando Sonic e passando os valores em 0
            Sonic ourico = new Sonic("Sonic", 0, 0);

            Console.WriteLine($"O {ourico.Nome} tem atualmente {ourico.Rings} rings💍 e {ourico.Esmeraldas} esmeraldas.💎");

            // garando valores aleatórios

            Random rnd = new Random();

            int ringsAleatorios = rnd.Next(50, 301);
            int esmeraldasAleatorias = rnd.Next(0, 8);

            // chamando método
            ourico.PegarRingsEsmeraldas(ringsAleatorios, esmeraldasAleatorias);

            Console.WriteLine(">>> Quantidade de Rings💍 e Esmeraldas coletados💎:");
            Console.WriteLine($"Agora ele tem {ourico.Rings} Rings💍 e {ourico.Esmeraldas} Esmeraldas💎.");
            Console.WriteLine("Rode o programa mais uma vez se quiser testar novamente.");
        }
    }
}
