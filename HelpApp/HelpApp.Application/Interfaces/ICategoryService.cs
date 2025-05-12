using HelpApp.Application.DTOs;
using System.Threading.Tasks;
using HelpApp.Application.Interfaces;
using System.Collections.Generic;

namespace HelpApp.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();

        Task<CategoryDTO> GetById(int? id);

        Task Add(CategoryDTO categoryDTO);

        Task Remove(int? id);

        Task Update(CategoryDTO categoryDTO);
    }
}
