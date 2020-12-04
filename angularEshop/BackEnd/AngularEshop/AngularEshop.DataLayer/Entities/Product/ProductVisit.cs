﻿using System.ComponentModel.DataAnnotations;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Product
{
    public class ProductVisit:BaseEntity
    {
        #region Properties

        public long ProductId { get; set; }
        
        [Display(Name = "IP")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string UserIp { get; set; }

        #endregion

        #region Relations

        public Product Product { get; set; }

        #endregion
    }
}