namespace Global5.Models.crud
{
    public class MovEstoque
    {

        public int int_id { get; set; } = 0;
        public int int_material { get; set; } = 0;
        public string? str_material { get; set; }
        public int? int_estoque_incial { get; set; } = null; 
        public int int_qtd_anterior { get; set; } = 0;
        public int int_qtd_desconto { get; set; } = 0;
        public int int_qtd_atual { get; set; } = 0;

    }
}
