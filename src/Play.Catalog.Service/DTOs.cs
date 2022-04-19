using System;
using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.DTOs
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    public record CreateItemDto([Required] string Name, string Description, [Range(0, Int32.MaxValue, ErrorMessage = "The field Price must be greater than 0.")] decimal Price);

    public record UpdateItemDto([Required] string Name, string Description, [Range(0, Int32.MaxValue, ErrorMessage = "The field Price must be greater than 0.")] decimal Price);
}