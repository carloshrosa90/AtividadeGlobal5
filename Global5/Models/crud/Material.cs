namespace Global5.Models.crud
{
    public class Material
    {
        public int int_id { get; set; }
        public string? str_descricao { get; set; }
        public decimal dec_valor { get; set; } = 0;
        public int int_estoque_incial { get; set; } = 0;
    }
}
