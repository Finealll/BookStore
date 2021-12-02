using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities.BaseObjects
{
    /// <summary>
    /// Тип - товар
    /// </summary>
    public class ProductObject : TypeObject
    {
        public ProductObject()
        {
            TypeName = nameof(ProductObject);
        }

        /// <summary>
        /// Получает или задает Имя товара
        /// </summary>
        public string Name { get; set; }   

        /// <summary>
        /// Получает или задает Ссылка на фото
        /// </summary>
        public string PhotoLink { get; set; } 

        /// <summary>
        /// Получает или задает Вес товара
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// Получает или задает Формат товара
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Получает или задает Описание товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Получает или задает Текущую цену
        /// </summary>
        public double Cost { get; set; }

        ///// <summary>
        ///// Получает или задает Ид текущей цены
        ///// </summary>
        //public int CurrentCostId { get; set; }


    }
}
