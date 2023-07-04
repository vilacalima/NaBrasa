namespace NaBrasa_Service.Model
{
    public class HamburguerMenu
    {
        ///<summary>
        ///Id do objeto Hamburguer
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do Lanche
        /// </summary>
        public string BurguerName { get; set; }
        /// <summary>
        /// Descrição do Lanche
        /// </summary>
        public string BurguerDescription { get; set; }
        /// <summary>
        /// Preço do Lanche
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Flag para ativar ou desativar o lanche
        /// </summary>
        public bool IsActive { get; set; }

    }
}
