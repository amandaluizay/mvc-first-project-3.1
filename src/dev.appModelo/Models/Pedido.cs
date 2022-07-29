using System;
namespace Model.Pedido { 
    //model de pedido com apenas atributo id
    public class Pedido 
    {
        public Guid Id { get; set; }

        public Pedido()
        {
            Id = Guid.NewGuid();
        }
    }
}
