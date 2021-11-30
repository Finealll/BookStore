using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IBaseObject
    {
        public int ID { get; set; }
        public bool Hidden { get; set; }
        public byte[] Rowversion { get; set; }
    }

    /// <summary>
    /// Базовый объект системы
    /// </summary>
    public class BaseObject : IBaseObject
    {
        [Key]
        public int ID { get; set; }
        public bool Hidden { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
