using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesDotNetCore.Model;
using MoviesDotNetCore.Repositories;

namespace MoviesDotNetCore.Controllers;

[ApiController]
[Route("search")]
public class SearchController
{
    private readonly IMovieRepository _movieRepository;

    public SearchController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public virtual System.Threading.Tasks.ValueTask<int> ReadAsync(Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default);
    {
        return _movieRepository.Search(search);
    }
}
