﻿using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Models;

namespace MiniMicroProject.API.Services.Interface
{
    public interface ICategoriesService
    {
        //Service was used to convert the data from the database directly into Dto. 
        Task<IEnumerable<CategoriesDto>> GetAllAsync();

    }
}

