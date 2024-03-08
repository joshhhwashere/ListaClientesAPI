namespace ListaClientesAPI.Models
{
    public class Recarga
    {
        public string Celular { get; set; }
        public float Cantidad { get; set; }
        public TipoCombo Tipo { get; set; }
        public string Cliente { get; set; }
        public Recarga()
        {
            Tipo = TipoCombo.Combo1;
        }
    }
    public enum TipoCombo
    {
        Recarga,
        Combo1,
        Combo2,
        Combo3
    }
}
