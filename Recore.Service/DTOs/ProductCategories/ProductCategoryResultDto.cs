﻿using Recore.Service.DTOs.Products;

namespace Recore.Service.DTOs.ProductCategories;

public class ProductCategoryResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductForRelationDto> Products { get; set; }
}