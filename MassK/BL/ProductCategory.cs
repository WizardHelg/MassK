namespace MassK.BL
{
    /// <summary>
    ///  Категории товаров. ThisProgramm\Settings\ProductCategory.xml
    /// </summary>
    class ProductCategory
    {
        public int ID { get; set; }

        public string Category { get; set; }

        public ProductCategory Clone() => new ProductCategory()
        {
            ID = this.ID,
            Category = this.Category
        };
    }
}
