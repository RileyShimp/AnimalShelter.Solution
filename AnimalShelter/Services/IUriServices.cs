using System;

namespace AnimalShelter.Models
{
  public interface IUriService
  {
      public Uri GetPageUri(PaginationFilter filter, string route);
  }
}