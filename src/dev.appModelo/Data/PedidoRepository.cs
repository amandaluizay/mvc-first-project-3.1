using Model.Pedido;
using static dev.appModelo.Data.PedidoRepository;

namespace dev.appModelo.Data
{
   //classes de injeção de depêndencia
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }


        public interface IPedidoRepository
        {
            Pedido ObterPedido();
        }
    }

   
}
