using MediatR;

namespace CQRS.Sample.Commands;

public record CreateProductCommand(string Name, decimal Price) : IRequest<Guid>;

public record UpdateProductCommand(Guid Id, string Name, decimal Price) : IRequest<bool>;

public record DeleteProductCommand(Guid Id) : IRequest<bool>;
