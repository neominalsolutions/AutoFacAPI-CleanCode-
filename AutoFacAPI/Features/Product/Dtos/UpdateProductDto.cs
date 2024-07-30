using MediatR;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AutoFacAPI.Features.Product.Dtos
{
  // Request Nesneleri Immutable olacağı için sadece Request aşamasında set ediliyor
  // Dtolar değer nesleri oldukları için Record tipleri, Record tipinde Id olmaz 
  // Entity ise referans nesneleri oldukları için Entity tipinde tanımlanır, Entity Idsiz olmaz
  public record UpdateProductDto(string Name,decimal Price,int Stock = 10):IRequest;
 
}
