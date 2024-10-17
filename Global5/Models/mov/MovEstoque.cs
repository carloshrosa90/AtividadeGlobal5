namespace Global5.Models.mov
{
    public class MovEstoque
    {
        public int int_id { get; set; }
        public int int_id_material { get; set; }
        public int int_id_fornecedor { get; set; }
        public int int_qtd_anterior { get; set; } = 0;
        public int int_qtd_desconto { get; set; } = 0;
        public int int_qtd_atual { get; set; } = 0;
        public DateTime dat_registro { get; set; }
    }
}
