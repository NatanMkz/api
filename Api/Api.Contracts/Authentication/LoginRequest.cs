namespace Api.Contracts.Login;

public record LoginRequest(    
    string Email,
    string Password
);