using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicTraining.Api.Models.Entities;
using BasicTraining.Api.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicTraining.Api.Controllers
{

    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        TrainingContext trainingContext;
        public CategoryController(TrainingContext trainingContext)
        {
            this.trainingContext = trainingContext;
        }

        [HttpGet, Route("")]
        public async Task<List<Category>> Get()
        {
            return await this.trainingContext.Category
                .Where(q => !q.IsDeleted)
                .ToListAsync();
        }

        [HttpPut, Route("")]
        public async Task<IActionResult> Create([FromBody]CreateRequestViewModel request)
        {
            this.trainingContext.Category.Add(new Category()
            {
                Name = request.Name,
                Slug = request.Slug,
                IsDeleted = false,
            });

            await this.trainingContext.SaveChangesAsync();

            return this.StatusCode(201);
        }

    }

}