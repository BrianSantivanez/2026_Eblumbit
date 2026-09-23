using System;
using EBlumbit.Builders;
using EBlumbit.Dto;
using EBlumbit.Repository.spec;
using EBlumbit.Services.spec;

namespace EBlumbit.Services.impl;

public class CategoriaService(ICategoriaRepository categoriaRepository) : ICategoriaService
{

    private readonly ICategoriaRepository _categoriaRepository = categoriaRepository;
    public async Task<IEnumerable<CategoriaResponseDto>> GetAllCategorias()
    {
        var categorias = await _categoriaRepository.GetAllCategorias();
        return categorias.Select(c => CategoriaBuilder.ToResponseDto(c));
    }

    public async Task<CategoriaResponseDto> GetCategoriasById(int id)
    {
        var categoria = await _categoriaRepository.GetCategoriaById(id);
        return CategoriaBuilder.ToResponseDto(categoria);
    }

    public async Task<CategoriaResponseDto> CreateCategoria(CreateCategoriaDto createCategoriaDto)
    {
        var categoria = await _categoriaRepository.CreateCategoria(CategoriaBuilder.ToEntity(createCategoriaDto));
        return CategoriaBuilder.ToResponseDto(categoria);
    }
    public async Task<CategoriaResponseDto> UpdateCategoria(int id, CreateCategoriaDto createCategoriaDto)
    {
        var categoria = await _categoriaRepository.GetCategoriaById(id);
        if (categoria == null) return null;
        var categoriaToUpdate = CategoriaBuilder.ToEntityUpdate(createCategoriaDto, id);
        return CategoriaBuilder.ToResponseDto(categoriaToUpdate);
    }
    public async Task DeleteAsync(int id)
    {
        var categoria = await _categoriaRepository.GetCategoriaById(id);
        if (categoria != null)
            await _categoriaRepository.DeleteCategoria(id);
    }
  
}