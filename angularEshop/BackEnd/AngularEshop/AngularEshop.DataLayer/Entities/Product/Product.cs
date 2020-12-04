using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Product
{
    public class Product:BaseEntity
    {
        #region Properties
        
        [Display(Name = "عنوان محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string ProductName { get; set; }
        
        [Display(Name = "قیمت")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public int Price { get; set; }
        
        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string ShortDescription { get; set; }
        
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Description { get; set; }
        
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string ImageName { get; set; }
        
        [Display(Name = "موجودی/یه اتمام رسیده")]
        public bool IsExist { get; set; }
        
        [Display(Name = "ویژه")]
        public bool IsSpecial { get; set; }

        
        #endregion

        #region Relations

        public ICollection<ProductGallery> ProductGalleries { get; set; }
        public ICollection<ProductVisit> ProductVisits { get; set; }
        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }
        
        #endregion
    }
}