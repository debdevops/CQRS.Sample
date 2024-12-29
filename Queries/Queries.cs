using CQRS.Sample.Models;
using MediatR;

namespace CQRS.Sample.Queries;

public record GetProductByIdQuery(Guid Id) : IRequest<Product?>;

public record GetAllProductsQuery : IRequest<IEnumerable<Product>>;
