namespace HEPAPOO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade  { get; set; }

        public virtual void Apresentação(){
        System.Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}