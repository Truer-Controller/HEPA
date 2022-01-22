namespace HEPAPOO
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentação(){
        System.Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos e sou aluno com nota {Nota}");
        }
    }
}