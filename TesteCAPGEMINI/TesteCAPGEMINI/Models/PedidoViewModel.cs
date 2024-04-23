using System.ComponentModel;

namespace TesteCAPGEMINI.Models
{
    public class PedidoViewModel
    {
        public Produto oProduto { get; set; }    
        public Cliente oCliente { get; set; }    
        public List<Cliente> oListCliente {  get; set; }
        public List<Produto> oListProduto { get; set; }
        public VwPedido oVwPedido {  get; set; }

        public int IdCliente {  get; set; }
        public int IdProduto {  get; set; }
        [DisplayName("Valor Total")]
        public string ValorTotal { get;  set; }   
    }
}
