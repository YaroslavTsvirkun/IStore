using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IStore.Models
{
    /// <summary>
    /// Класс описывающий продукт
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// Имя продукта
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Описания продукта
        /// </summary>
        public String Descriptions { get; set; }

        /// <summary>
        /// Цена продукта в прайсе
        /// </summary>
        public Decimal Price { get; set; }

        /// <summary>
        /// Категория продукта
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// Конструктор для инициализации нового продукта, без параметров
        /// </summary>
        public ProductModel() { }

        /// <summary>
        /// Конструктор для инициализации нового продукта, с параметрами
        /// </summary>
        public ProductModel(Int32 Id, String Name, String Descriptions, Decimal Price, String Category)
        {
            this.Id = Id;
            this.Name = Name;
            this.Descriptions = Descriptions;
            this.Price = Price;
            this.Category = Category;
        }
    }
}