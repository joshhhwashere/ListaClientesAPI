namespace ListaClientesAPI.Models
{
    public class Telefonia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ServiciosAOfrecer Servicios { get; set; }
        public Telefonia()
        {
            Servicios = ServiciosAOfrecer.MinutosMegas;
        }
    }
    public enum ServiciosAOfrecer
    {
        MinutosMegas,
        MinutosMegasInternet,
        MinutosMegasInternetServiciosAdicionales
    }
}
