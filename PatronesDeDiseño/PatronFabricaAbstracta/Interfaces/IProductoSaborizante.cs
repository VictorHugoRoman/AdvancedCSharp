namespace PatronesDeDiseño.PatronFabricaAbstracta.Interfaces
{
    //Interfaz para los saborizantes
    public interface IProductoSaborizante
    {
        void Obtener();
        string Informacion(); 
        //podemos meter las acciones necesarias dependiendo del articulo en particular q deseamos crear
    }
}