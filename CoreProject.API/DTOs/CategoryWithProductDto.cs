using CoreProject.API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.API.DTOs
{
    public class CategoryWithProductDto : CategoryDto
    {
        //public IEnumerable<ProductDto> Products { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}