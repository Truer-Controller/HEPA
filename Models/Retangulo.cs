namespace HEPAPOO
{
    public class Retangulo
    {
        private double largura, altura;
        private bool valido;

        public void DefinirMedidas(double largura, double altura){
            if(largura > 0 && altura > 0){
                this.largura = largura;
                this.altura = altura;
                this.valido = true;
            }
            else{
                System.Console.WriteLine("Valores invalidos");
            }
        }
        public double ObterArea(){
                if(valido){
                    return largura * altura;
                }
                else{
                    System.Console.WriteLine("Digite valores validos");
                    return 0;
                }
        }
    }
}