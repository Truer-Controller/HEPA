namespace HEPAPOO
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentação(){
        System.Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos e sou professor com o {Salario}");
        }
    }
}