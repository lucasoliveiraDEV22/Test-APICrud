namespace ApiCrud.Models
{
    public class VendaViewModel
    {
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public int QtdVenda { get; set; }
        public float VlrUnitarioVenda { get; set; }
        public string DthVenda { get; set; }
        public float VlrTotalVenda => QtdVenda * VlrUnitarioVenda;
    }
}
