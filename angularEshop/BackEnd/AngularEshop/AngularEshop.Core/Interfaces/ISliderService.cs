﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Site;

namespace AngularEshop.Core.Interfaces
{
    public interface ISliderService:IDisposable
    {
        Task<List<Slider>> GetAllSliders();
        Task<List<Slider>> GetActiveSliders();
        Task AddSlider(Slider slider);
        Task UpdateSlider(Slider slider);
        Task<Slider> GetSliderById(long sliderId);
    }
}