namespace HEPAPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.Saldo = valor;
        }
    }
}