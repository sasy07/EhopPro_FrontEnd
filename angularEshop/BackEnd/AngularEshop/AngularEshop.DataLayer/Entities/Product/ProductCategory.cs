﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Product
{
    public class ProductCategory:BaseEntity
    {
        #region Properties

        public string Title { get; set; }
        public long? ParentId { get; set; }

        #endregion

        #region Relations

        [ForeignKey("ParentId")]
        public ProductCategory ParentCategory { get; set; }
        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }

        #endregion
    }
}   