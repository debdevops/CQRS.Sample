using CQRS.Sample.Data;
using CQRS.Sample.Models;
using CQRS.Sample.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Sample.Handlers;

public class ProductQueryHandler :
    IRequestHandler<GetProductByIdQuery, Product?>,
    IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    private readonly AppDbContext _context;

    public ProductQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Product?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products.FindAsync(request.Id);
    }

    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products.ToListAsync(cancellationToken);
    }
}
