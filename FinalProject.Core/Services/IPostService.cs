using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.DTOs;

namespace FinalProject.Core.Services
{
    public interface IPostService
    {
        CustomResponseDto<List<PostDto>> GetAll();
        CustomResponseDto<PostDto> Create(PostCreateDto request);
        CustomResponseDto<PostDto> Update(PostUpdateDto request);
        CustomResponseDto<string> Delete(int id);
    }
}
